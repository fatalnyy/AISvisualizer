using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AISvisualizer.Enums;
using AISvisualizer.Models;

namespace AISvisualizer.Services
{
    public class DecodeService : IDecodeService
    {
        public string BinaryPayload { get; set; }
        private readonly IExtractService _extractService;
        public DecodeService(IExtractService extractService)
        {
            _extractService = extractService;
        }

        public Message GetDecodedMessage(string payload)
        {
            BinaryPayload = _extractService.GetBinaryPayload(payload);
            var messageType = GetMessageType();

            if (messageType > 0)
            {
                switch (messageType)
                {
                    case (Int16)Enums.Enums.MessageTypes.MessageType1:
                    case (Int16)Enums.Enums.MessageTypes.MessageType2:
                    case (Int16)Enums.Enums.MessageTypes.MessageType3:
                        return new Message
                        {
                            MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType),
                            Repeat = GetRepeatIndicator(),
                            MMSI = GetMMSI(),
                            Status = GetNavigationStatus(),
                            ROT = GetRateOfTurn(),
                            SOG = GetSpeedOverGround(),
                            Accuracy = GetPositionAccuracy(),
                            Longitude = GetLongitude(),
                            Latitude = GetLatitude(),
                            COG = GetCourseOverGround(),
                            HDG = GetTrueHeading(),
                            Timestamp = GetTimestamp(),
                            Maneuver = GetManeuverIndicator(),
                            RAIM = GetRAIMFlag()
                        };
                    default:
                        return null;
                }
            }
            else
                return null;

        }

        public Int16 GetMessageType()
        {
            var binMessageType = _extractService.ExtractBinaryFieldValue(BinaryPayload, 0, 6);
            var messageType = Convert.ToInt16(binMessageType, 2);

            if (messageType == 0 || messageType > 27) return -1;

            return messageType;
        }

        public Int16 GetRepeatIndicator()
        {
            var binRepeatIndicator = _extractService.ExtractBinaryFieldValue(BinaryPayload, 6, 2);
            var repeatIndicator = Convert.ToInt16(binRepeatIndicator, 2);

            return repeatIndicator;
        }

        public Int64 GetMMSI()
        {
            var binMMSI = _extractService.ExtractBinaryFieldValue(BinaryPayload, 8, 30);
            var MMSI = Convert.ToInt64(binMMSI, 2);

            return MMSI;
        }

        public string GetNavigationStatus()
        {
            var binNavigationStatus = _extractService.ExtractBinaryFieldValue(BinaryPayload, 38, 4);
            var navigationStatus = Convert.ToInt16(binNavigationStatus, 2);

            if (navigationStatus > 15) return ("Invalid navigation status!");
            return Enums.Enums.GetEnumDescription<Enums.Enums.NavigationStatus>(navigationStatus);
        }

        public Int16? GetRateOfTurn()
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

            return (Int16)ROT_sensor;
        }

        public double? GetSpeedOverGround()
        {
            var binSOG = _extractService.ExtractBinaryFieldValue(BinaryPayload, 50, 10);
            var convertedSOG = Convert.ToInt16(binSOG, 2);

            if (convertedSOG == 1023) return null; // "Not available SOG";

            double SOG = (double)convertedSOG * 0.1;

            return Math.Round(SOG, 3);
        }

        public string GetPositionAccuracy()
        {
            var binPositionAccuracy = _extractService.ExtractBinaryFieldValue(BinaryPayload, 60, 1);
            var positionAccuracy = Convert.ToInt16(binPositionAccuracy, 2);

            if (positionAccuracy == 1) return "<10m";
            else if (positionAccuracy == 0) return ">10m";
            else return "Error";
        }

        public double GetLongitude()
        {
            var binLongitude = _extractService.ExtractBinaryFieldValue(BinaryPayload, 61, 28);
            var convertedLongitude = Convert.ToInt64(binLongitude, 2);

            if (binLongitude[0] == '1')
                convertedLongitude = (convertedLongitude & 0x07FFFFFF) - 0x08000000;

            double longitude = ((double)convertedLongitude / 600000.0);

            if (longitude < -180.0 || longitude > 180.0) throw new InvalidOperationException("Invalid longitude");
            return Math.Round(longitude, 6);
        }

        public double GetLatitude()
        {
            var binLatitude = _extractService.ExtractBinaryFieldValue(BinaryPayload, 89, 27);
            var convertedLatitude = Convert.ToInt64(binLatitude, 2);

            if (binLatitude[0] == '1')
                convertedLatitude = (convertedLatitude & 0x03FFFFFF) - 0x04000000;

            double latitude = ((double)convertedLatitude / 600000.0);

            if (latitude < -90.0 || latitude > 90.0) throw new InvalidOperationException("Invalid latitude");
            return Math.Round(latitude, 6);
        }

        public double? GetCourseOverGround()
        {
            var binCOG = _extractService.ExtractBinaryFieldValue(BinaryPayload, 116, 12);
            var convertedCOG = Convert.ToInt16(binCOG, 2);

            if (convertedCOG == 3600) return null; // "Not available";

            double COG = (double)convertedCOG * 0.1;

            if (COG > 360.0) throw new InvalidOperationException("Invalid COG > 360[deg]");

            return Math.Round(COG, 1);
        }

        public Int16? GetTrueHeading()
        {
            var binTrueHeading = _extractService.ExtractBinaryFieldValue(BinaryPayload, 128, 9);
            var trueHeading = Convert.ToInt16(binTrueHeading, 2);
             
            if (trueHeading == 511) return null; // "Not available";
            if (trueHeading > 359) return null; // "Error";

            return trueHeading;
        }

        public string GetTimestamp()
        {
            var binTimeStamp = _extractService.ExtractBinaryFieldValue(BinaryPayload, 137, 6);
            var timeStamp = Convert.ToInt16(binTimeStamp, 2);

            if (timeStamp == 60) return "Not available";
            else if (timeStamp == 61) return "System in manual input mode";
            else if (timeStamp == 62) return "System in estimated mode";
            else if (timeStamp == 63) return "System inoperative";

            return string.Format("{0} [s]", timeStamp.ToString());
        }

        public string GetManeuverIndicator()
        {
            var binManeuverIndicator = _extractService.ExtractBinaryFieldValue(BinaryPayload, 143, 2);
            var maneuverIndicator = Convert.ToInt16(binManeuverIndicator, 2);

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

        public string GetRAIMFlag()
        {
            var binRAIMFlag = _extractService.ExtractBinaryFieldValue(BinaryPayload, 148, 1);
            var RAIMFlag = Convert.ToInt16(binRAIMFlag, 2);

            if (RAIMFlag == 1) return "In use";
            else if (RAIMFlag == 0) return "Not in use";
            else return "Error";
        }

        public string GetRadioStatus()
        {
            return null;
            //return binaryPayload.Substring(149, 19);
        }
    }
}
