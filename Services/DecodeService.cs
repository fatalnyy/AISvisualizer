using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AISvisualizer.Enums;
using AISvisualizer.Models;

namespace AISvisualizer.Services
{
    public class DecodeService : IDecodeService
    {

        private readonly IExtractService _extractService;
        public string BinaryPayload { get; set; }
        public string Packet { get; set; }
        public string Channel { get; set; }
        public Int64 MMSI { get; set; }
        public DateTime? Date { get; set; }

        public DecodeService(IExtractService extractService)
        {
            _extractService = extractService;
        }

        public Int16 GetInt16(int startIndex, int length)
        {
            var binValue = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            Int16 value = 0;

            if (!string.IsNullOrWhiteSpace(binValue))
                value = Convert.ToInt16(binValue, 2);

            return value;
        }

        public Int32 GetInt32(int startIndex, int length)
        {
            var binValue = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var value = Convert.ToInt32(binValue, 2);

            return value;
        }

        public Int64 GetInt64(int startIndex, int length)
        {
            var binValue = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var value = Convert.ToInt64(binValue, 2);

            return value;
        }

        public Int16 GetMessageType()
        {
            var messageType = GetInt16(0, 6);
            if (messageType == 0 || messageType > 27) return -1;

            return messageType;
        }

        public string GetNavigationStatus()
        {
            var navigationStatus = GetInt16(38, 4);

            if (navigationStatus > 15) return ("Invalid navigation status!");
            return Enums.Enums.GetEnumDescription<Enums.Enums.NavigationStatus>(navigationStatus);
        }

        public double? GetRateOfTurn()
        {
            var binROT = _extractService.ExtractBinaryFieldValue(BinaryPayload, 42, 8);
            bool negative = false;

            var ROT_AIS = Convert.ToInt32(binROT, 2);

            if (ROT_AIS == 128)
                return null; // "Not available";

            if (binROT[0] == '1')
            {
                ROT_AIS = (ROT_AIS & 0x7F) - 0x80;
                negative = true;
            }

            var ROT_sensor = (double)ROT_AIS / 4.773;
            ROT_sensor *= ROT_sensor;
            ROT_sensor = Math.Round(ROT_sensor);
            ROT_sensor = negative ? -ROT_sensor : ROT_sensor;

            return ROT_sensor;
        }

        public double? GetSpeedOverGround(int startIndex, int length)
        {
            var convertedSOG = GetInt16(startIndex, length);
            if (convertedSOG == 1023) return null; // "Not available SOG";

            double SOG = (double)convertedSOG * 0.1;

            return Math.Round(SOG, 3);
        }

        public string GetPositionAccuracy(int startIndex, int length)
        {
            var positionAccuracy = GetInt16(startIndex, length);

            if (positionAccuracy == 1) return "<10m";
            else if (positionAccuracy == 0) return ">10m";
            else return "Error";
        }

        public double GetLongitude(int startIndex, int length)
        {
            var binLongitude = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var convertedLongitude = Convert.ToInt64(binLongitude, 2);

            if (binLongitude[0] == '1')
                convertedLongitude = (convertedLongitude & 0x07FFFFFF) - 0x08000000;

            double longitude = ((double)convertedLongitude / 600000.0);

            // if (longitude < -180.0 || longitude > 180.0) throw new InvalidOperationException("Invalid longitude");

            return Math.Round(longitude, 6);
        }

        public double GetLatitude(int startIndex, int length)
        {
            var binLatitude = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var convertedLatitude = Convert.ToInt64(binLatitude, 2);

            if (binLatitude[0] == '1')
                convertedLatitude = (convertedLatitude & 0x03FFFFFF) - 0x04000000;

            double latitude = ((double)convertedLatitude / 600000.0);

            //if (latitude < -90.0 || latitude > 90.0) throw new InvalidOperationException("Invalid latitude");
            return Math.Round(latitude, 6);
        }

        public double? GetCourseOverGround(int startIndex, int length)
        {
            var convertedCOG = GetInt16(startIndex, length);

            if (convertedCOG == 3600) return null; // "Not available";

            double COG = (double)convertedCOG * 0.1;

            if (COG > 360.0) return null; // throw new InvalidOperationException("Invalid COG > 360[deg]");

            return Math.Round(COG, 1);
        }

        public Int16? GetTrueHeading()
        {
            var trueHeading = GetInt16(128, 9);
             
            if (trueHeading == 511) return null; // "Not available";
            if (trueHeading > 359) return null; // "Error";

            return trueHeading;
        }

        public Int16 GetTimestamp(int startIndex, int length)
        {
            var timeStamp = GetInt16(startIndex, length);

            return timeStamp;
        }

        public string GetManeuverIndicator()
        {
            var maneuverIndicator = GetInt16(143, 2);

            switch (maneuverIndicator)
            {
                case 0:
                    return "Not available";
                case 1:
                    return "No special maneuver";
                case 2:
                    return "Special maneuver";
                default:
                    return "Error";
            }
        }

        public string GetRAIMFlag(int startIndex,int length)
        {
            var RAIMFlag = GetInt16(startIndex, length);

            if (RAIMFlag == 1) return "In use";
            else if (RAIMFlag == 0) return "Not in use";
            else return "Error";
        }

        public DateTime? GetDateOfMessageType4()
        {
            var year = GetInt16(38, 14);
            if (year == 0) return null;

            var month = GetInt16(52, 4);
            if (month == 0) return null;

            var day = GetInt16(56, 5);
            if (day == 0) return null;

            var date = new DateTime(year, month, day);

            var hour = GetInt16(61, 5);
            if (hour == 0) return date;

            var minute = GetInt16(66, 6);
            if (minute == 0) return date;

            var second = GetInt16(72, 6);
            date = new DateTime(year, month, day, hour, minute, second);

            return date;
        }

        public string GetEPFD(int startIndex, int length)
        {
            var EPFD = GetInt16(startIndex, length);

            if (EPFD > 8) return ("Undefined");
            return Enums.Enums.GetEnumDescription<Enums.Enums.EPFDfixTypes>(EPFD);
        }

        public string GetAISversion()
        {
            var version = GetInt16(38, 2);

            if (version == 0) return "ITU1371";
            else if (version > 0 && version < 4) return "Future editions";
            else return "Error";
        }

        public string GetString(int startIndex, int length)
        {
            var binStringData = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);

            var value = string.Empty;
            for (var i = 0; i < binStringData.Length / 6; i++)
            {
                var b = Convert.ToByte(binStringData.Substring(i * 6, 6), 2);

                if (b < 32) //convert to 6-bit ASCII, chars to uppercase latins
                    b = (byte)(b + 64);

                if (b != 64)
                    value = value + (char)b;
            }

            return value.Trim();
        }

        public string GetShipType()
        {
            var shipType = GetInt16(232, 8);

            if (shipType > 99) return ("Invalid Ship Type!");
            return Enum.ToObject(typeof(Enums.Enums.ShipType), shipType).ToString();
        }

        public Int16? GetPartOfDate(int startIndex, int length, bool month = false, bool day = false, bool hour = false, bool minute = false)
        {
            var value = GetInt16(startIndex, length);

            if (month && value == 0) return null;
            if (day && value == 0) return null;
            if (hour && value == 24) return null;
            if (minute && value == 60) return null;

            return value;
        }

        public double GetDraught(int startIndex, int length)
        {
            var convertedDraught = GetInt16(startIndex, length);

            double draught = (double)convertedDraught/ 10;
            return draught;
        }

        public string GetDTE(int startIndex, int length)
        {
            var DTE = GetInt16(startIndex, length);

            if (DTE == 0) return "Data terminal ready";
            else if (DTE == 1) return "Not ready";
            else return "Error";
        }

        public string GetAltitude(int startIndex, int length)
        {
            var alt = GetInt16(startIndex, length);

            if (alt == 4095) return "Not available";
            else if (alt == 4094) return ">= 4094";
            else return alt.ToString();
        }

        public string GetAssinged(int startIndex, int length)
        {
            var assigned = GetInt16(startIndex, length);

            if (assigned == 0) return "Autonomous mode";
            else return "Assigned mode";
        }

        public string GetAidType()
        {
            var aid = GetInt16(38, 5);

            if (aid > 31) return ("Invalid Aid Type!");
            return Enums.Enums.GetEnumDescription<Enums.Enums.AidType>(aid);
        }

        public string GetOffPositionIndicator()
        {
            var offPosition = GetInt16(259, 1);

            if (offPosition == 0) return "On position";
            else return "Off position";
        }

        public string GetVirtualAidFlag()
        {
            var aidFlag = GetInt16(269, 1);

            if (aidFlag == 0) return "Real AtoN";
            else return "Virtual AtoN";
        }

        public string GetCountry()
        {
            var mmsi = MMSI.ToString();
            var firstDigit = Convert.ToInt32(mmsi.Substring(0, 1));
            var country = "";
            
            if (firstDigit == 8) country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(1, 3))).ToString();
            else if (firstDigit >= 2 && firstDigit <= 7) country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(0, 3))).ToString();
            else if (firstDigit == 0)
            {
                var secondDigit = Convert.ToInt32(mmsi.Substring(1, 1));

                if (secondDigit == 0) country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(2, 3))).ToString();
                else country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(1, 3))).ToString();
            }
            else if (firstDigit == 1)
            {
                var secondDigit = Convert.ToInt32(mmsi.Substring(1, 1));
                var thirdDigit = Convert.ToInt32(mmsi.Substring(2, 1));

                if (secondDigit == 1 && thirdDigit == 1) country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(4, 3))).ToString();
                else country = null;
            }
            else if (firstDigit == 9)
            {
                var secondDigit = Convert.ToInt32(mmsi.Substring(1, 1));

                if (secondDigit == 9 || secondDigit == 8) country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(2, 3))).ToString();
                else if (secondDigit == 7)
                {
                    var thirdDigit = Convert.ToInt32(mmsi.Substring(2, 1));

                    if (thirdDigit == 0) country = Enum.ToObject(typeof(Enums.Enums.MIDcountries), Convert.ToInt32(mmsi.Substring(3, 3))).ToString();
                    else country = null;
                }
                else country = null;
            }
            else country = null;

            if (!string.IsNullOrWhiteSpace(country)) country = Regex.Replace(country, @"[\d-]", string.Empty);

            return country;
        }
    }
}
