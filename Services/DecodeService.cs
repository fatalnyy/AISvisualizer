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
        int counter = 0;
        public string BinaryPayload { get; set; }
        public string FragmentOfPayload { get; set; }
        public string EncodedPayload { get; set; }
        public string Packet { get; set; }
        public string Channel { get; set; }
        public Int64 MMSI { get; set; }

        private readonly IExtractService _extractService;
        public DecodeService(IExtractService extractService)
        {
            _extractService = extractService;
        }

        public async Task<DecodedMessages> GetDecodedMessage(IAsyncEnumerable<LineContent> lineContents)
        {
            var decodedMessages = new DecodedMessages();

            await foreach (var lineContent in lineContents)
            {
                var numSentences = Convert.ToInt32(lineContent.AISmessage.MessageCount);
                var numFillBits = Convert.ToInt32(lineContent.AISmessage.Size.Substring(0, 1));
                var fragmentNumber = Convert.ToInt32(lineContent.AISmessage.MessageNumber);

                if (numSentences > 1 && fragmentNumber == 1)
                {
                    FragmentOfPayload = lineContent.AISmessage.Payload;
                    continue;
                }

                if (numSentences > 1 && fragmentNumber == 2)
                    EncodedPayload = FragmentOfPayload + lineContent.AISmessage.Payload;
                else
                    EncodedPayload = lineContent.AISmessage.Payload;

                BinaryPayload = _extractService.GetBinaryPayload(EncodedPayload, numFillBits);
                if (string.IsNullOrWhiteSpace(BinaryPayload)) continue;

                Packet = lineContent.AISmessage.Format;
                Channel = lineContent.AISmessage.Channel;
                MMSI = GetMMSI();

                if (MMSI <= 99999999)
                {
                    counter++;
                    continue;
                }
                var messageType = GetMessageType();

                if (messageType > 0)
                {
                    switch (messageType)
                    {
                        case (Int16)Enums.Enums.MessageTypes.MessageType1:
                        case (Int16)Enums.Enums.MessageTypes.MessageType2:
                        case (Int16)Enums.Enums.MessageTypes.MessageType3:
                            MessageType123 messageType123 = GetMessageType123(messageType);
                            decodedMessages.MessageType123s.Add(messageType123);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType4:
                            MessageType4 messageType4 = GetMessageType4(messageType);
                            decodedMessages.MessageType4s.Add(messageType4);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType5:
                            MessageType5 messageType5 = GetMessageType5(messageType);
                            decodedMessages.MessageType5s.Add(messageType5);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType9:
                            MessageType9 messageType9 = GetMessageType9(messageType);
                            decodedMessages.MessageType9s.Add(messageType9);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType21:
                            MessageType21 messageType21 = GetMessageType21(messageType);
                            decodedMessages.MessageType21s.Add(messageType21);
                            break;
                        default:
                            continue;
                    }
                }
                else
                    continue;
            }
            return decodedMessages;         
        }

        public MessageType123 GetMessageType123(Int16 messageType)
        {
            return new MessageType123
            {
                MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType),
                Repeat = GetRepeatIndicator(),
                MMSI = MMSI,
                Packet = Packet,
                Channel = Channel,
                Status = GetNavigationStatus(),
                ROT = GetRateOfTurn(),
                SOG = GetSpeedOverGround(50, 10),
                Accuracy = GetPositionAccuracy(60, 1),
                Longitude = GetLongitude(61, 28),
                Latitude = GetLatitude(89, 27),
                COG = GetCourseOverGround(116, 12),
                HDG = GetTrueHeading(),
                Timestamp = GetTimestamp(137, 6),
                Maneuver = GetManeuverIndicator(),
                RAIM = GetRAIMFlag(148, 1),
                Country = GetCountry()
            };
        }

        public MessageType4 GetMessageType4(Int16 messageType)
        {
            return new MessageType4
            {
                MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType),
                Repeat = GetRepeatIndicator(),
                MMSI = MMSI,
                Packet = Packet,
                Channel = Channel,
                Date = GetDateOfMessageType4(),
                FixQuality = GetPositionAccuracy(78, 1),
                Longitude = GetLongitude(79, 28),
                Latitude = GetLatitude(107, 27),
                EPFD = GetEPFD(134, 4),
                RAIM = GetRAIMFlag(148, 1),
                Country = GetCountry()
            };
        }

        public MessageType5 GetMessageType5(Int16 messageType)
        {
            return new MessageType5
            {
                MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType),
                Repeat = GetRepeatIndicator(),
                MMSI = MMSI,
                Packet = Packet,
                Channel = Channel,
                AISversion = GetAISversion(),
                IMOnumber = GetIMOnumber(),
                CallSign = GetString(70, 42),
                VesselName = GetString(112, 120),
                ShipType = GetShipType(),
                DimensionToBow = GetDimensionToBowOrToStern(240, 9),
                DimensionToStern = GetDimensionToBowOrToStern(249, 9),
                DimensionToPort = GetDimensionToPortOrToStarboard(258, 6),
                DimensionToStarboard = GetDimensionToPortOrToStarboard(264, 6),
                EPFD = GetEPFD(270, 4),
                Month = GetPartOfDate(274, 4, true),
                Day = GetPartOfDate(278, 5, false, true),
                Hour = GetPartOfDate(283, 5, false, false, true),
                Minute = GetPartOfDate(288, 6, false, false, false, true),
                Draught = GetDraught(294, 8),
                Destination = GetString(302, 120),
                DTE = GetDTE(422, 1),
                Country = GetCountry()
            };
        }

        public MessageType9 GetMessageType9(Int16 messageType)
        {
            return new MessageType9
            {
                MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType),
                Repeat = GetRepeatIndicator(),
                MMSI = MMSI,
                Packet = Packet,
                Channel = Channel,
                Altitude = GetAltitude(38, 12),
                SOG = GetSpeedOverGround(50, 10),
                Accuracy = GetPositionAccuracy(60, 1),
                Longitude = GetLongitude(61, 28),
                Latitude = GetLatitude(89, 27),
                COG = GetCourseOverGround(116, 12),
                Timestamp = GetTimestamp(128, 6),
                DTE = GetDTE(142, 1),
                Assigned = GetAssinged(146, 1),
                RAIM = GetRAIMFlag(147, 1),
                Country = GetCountry()
            };
        }

        public MessageType21 GetMessageType21(Int16 messageType)
        {
            return new MessageType21
            {
                MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType),
                Repeat = GetRepeatIndicator(),
                MMSI = MMSI,
                Packet = Packet,
                Channel = Channel,
                AidType = GetAidType(),
                Name = GetString(43, 120),
                Accuracy = GetPositionAccuracy(163, 1),
                Longitude = GetLongitude(164, 28),
                Latitude = GetLatitude(192, 27),
                DimensionToBow = GetDimensionToBowOrToStern(219, 9),
                DimensionToStern = GetDimensionToBowOrToStern(228, 9),
                DimensionToPort = GetDimensionToPortOrToStarboard(237, 6),
                DimensionToStarboard = GetDimensionToPortOrToStarboard(243, 6),
                EPFD = GetEPFD(249, 4),
                Second = GetTimestamp(253, 6),
                OffPosition = GetOffPositionIndicator(),
                RAIM = GetRAIMFlag(268, 1),
                VirtualAidFlag = GetVirtualAidFlag(),
                Assigned = GetAssinged(270, 1),
                Country = GetCountry()
            };
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

        public double? GetSpeedOverGround(int startIndex, int length)
        {
            var binSOG = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var convertedSOG = Convert.ToInt16(binSOG, 2);

            if (convertedSOG == 1023) return null; // "Not available SOG";

            double SOG = (double)convertedSOG * 0.1;

            return Math.Round(SOG, 3);
        }

        public string GetPositionAccuracy(int startIndex, int length)
        {
            var binPositionAccuracy = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var positionAccuracy = Convert.ToInt16(binPositionAccuracy, 2);

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
            var binCOG = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
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

        public string GetTimestamp(int startIndex, int length)
        {
            var binTimeStamp = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var timeStamp = Convert.ToInt16(binTimeStamp, 2);

            if (timeStamp == 60) return "Not available";
            else if (timeStamp == 61) return "System in manual input mode";
            else if (timeStamp == 62) return "System in estimated mode";
            else if (timeStamp == 63) return "System inoperative";

            return string.Format("{0}", timeStamp.ToString());
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

        public string GetRAIMFlag(int startIndex,int length)
        {
            var binRAIMFlag = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
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

        public DateTime? GetDateOfMessageType4()
        {
            var binYear = _extractService.ExtractBinaryFieldValue(BinaryPayload, 38, 14);
            var year = Convert.ToInt16(binYear, 2);

            if (year == 0) return null;

            var binMonth = _extractService.ExtractBinaryFieldValue(BinaryPayload, 52, 4);
            var month = Convert.ToInt16(binMonth, 2);

            if (month == 0) return null;

            var binDay = _extractService.ExtractBinaryFieldValue(BinaryPayload, 56, 5);
            var day = Convert.ToInt16(binDay, 2);

            if (day == 0) return null;

            var date = new DateTime(year, month, day);

            var binHour = _extractService.ExtractBinaryFieldValue(BinaryPayload, 61, 5);
            var hour = Convert.ToInt16(binHour, 2);

            if (hour == 0) return date;

            var binMinute = _extractService.ExtractBinaryFieldValue(BinaryPayload, 66, 6);
            var minute = Convert.ToInt16(binMinute, 2);

            if (minute == 0) return date;

            var binSecond = _extractService.ExtractBinaryFieldValue(BinaryPayload, 72, 6);
            var second = Convert.ToInt16(binSecond, 2);

            date = new DateTime(year, month, day, hour, minute, second);

            return date;
        }

        public string GetEPFD(int startIndex, int length)
        {
            var binEPFD = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var EPFD = Convert.ToInt16(binEPFD, 2);

            if (EPFD > 8) return ("Undefined");
            return Enums.Enums.GetEnumDescription<Enums.Enums.EPFDfixTypes>(EPFD);
        }

        public string GetAISversion()
        {
            var binVersion = _extractService.ExtractBinaryFieldValue(BinaryPayload, 38, 2);
            var version = Convert.ToInt16(binVersion, 2);

            if (version == 0) return "ITU1371";
            else if (version > 0 && version < 4) return "Future editions";
            else return "Error";
        }

        public Int64 GetIMOnumber()
        {
            var binIMOnumber = _extractService.ExtractBinaryFieldValue(BinaryPayload, 40, 30);
            var IMOnumber = Convert.ToInt64(binIMOnumber, 2);

            return IMOnumber;
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
            var binShipType = _extractService.ExtractBinaryFieldValue(BinaryPayload, 232, 8);
            var shipType = Convert.ToInt16(binShipType, 2);

            if (shipType > 99) return ("Invalid Ship Type!");
            return Enum.ToObject(typeof(Enums.Enums.ShipType), shipType).ToString();
        }

        public string GetDimensionToBowOrToStern(int startIndex, int length)
        {
            var binDimension = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var dimension = Convert.ToInt16(binDimension, 2);

            if (dimension == 511) return ">511";
            return dimension.ToString();
        }

        public string GetDimensionToPortOrToStarboard(int startIndex, int length)
        {
            var binDimension = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var dimension = Convert.ToInt16(binDimension, 2);

            if (dimension == 63) return ">63";
            return dimension.ToString();
        }

        public Int16? GetPartOfDate(int startIndex, int length, bool month = false, bool day = false, bool hour = false, bool minute = false)
        {
            var binValue = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var value = Convert.ToInt16(binValue, 2);

            if (month && value == 0) return null;
            if (day && value == 0) return null;
            if (hour && value == 24) return null;
            if (minute && value == 60) return null;

            return value;
        }

        public double GetDraught(int startIndex, int length)
        {
            var binDraught = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var convertedDraught = Convert.ToInt16(binDraught, 2);

            double draught = (double)convertedDraught/ 10;

            return draught;
        }

        public string GetDTE(int startIndex, int length)
        {
            var binDTE = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var DTE = Convert.ToInt16(binDTE, 2);

            if (DTE == 0) return "Data terminal ready";
            else if (DTE == 1) return "Not ready";
            else return "Error";
        }

        public string GetAltitude(int startIndex, int length)
        {
            var binAlt = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var alt = Convert.ToInt16(binAlt, 2);

            if (alt == 4095) return "Not available";
            else if (alt == 4094) return ">= 4094";
            else return alt.ToString();
        }

        public string GetAssinged(int startIndex, int length)
        {
            var binAssigned = _extractService.ExtractBinaryFieldValue(BinaryPayload, startIndex, length);
            var assigned = Convert.ToInt16(binAssigned, 2);

            if (assigned == 0) return "Autonomous mode";
            else return "Assigned mode";
        }

        public string GetAidType()
        {
            var binAid = _extractService.ExtractBinaryFieldValue(BinaryPayload, 38, 5);
            var aid = Convert.ToInt16(binAid, 2);

            if (aid > 31) return ("Invalid Aid Type!");
            return Enums.Enums.GetEnumDescription<Enums.Enums.AidType>(aid);

        }

        public string GetOffPositionIndicator()
        {
            var binOffPosition = _extractService.ExtractBinaryFieldValue(BinaryPayload, 259, 1);
            var offPosition = Convert.ToInt16(binOffPosition, 2);

            if (offPosition == 0) return "On position";
            else return "Off position";
        }

        public string GetVirtualAidFlag()
        {
            var binAidFlag = _extractService.ExtractBinaryFieldValue(BinaryPayload, 269, 1);
            var aidFlag = Convert.ToInt16(binAidFlag, 2);

            if (aidFlag == 0) return "Real AtoN";
            else return "Virtual AtoN";
        }

        public string GetCountry()
        {
            var mmsi = GetMMSI().ToString();
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
