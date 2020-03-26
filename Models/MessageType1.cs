using AISvisualizer.Services;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISvisualizer.Models
{
    public class MessageType1 : Message
    {
        public string Status { get; set; }
        public double? ROT { get; set; }
        public double? SOG { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? COG { get; set; }
        public Int16? HDG { get; set; }
        public Int16 Timestamp { get; set; }
        public string Maneuver { get; set; }
        public Int16 Spare { get; set; }
        public string RAIM { get; set; }
        public int RadioStatus { get; set; }
        public int MessageType5_Id { get; set; }

        [ForeignKey("MessageType5_Id")]
        public virtual MessageType5 MessageType5 { get; set; }

        public MessageType1(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
            Status = decodeService.GetNavigationStatus();
            ROT = decodeService.GetRateOfTurn();
            SOG = decodeService.GetSpeedOverGround(50, 10);
            Accuracy = decodeService.GetPositionAccuracy(60, 1);
            Longitude = decodeService.GetLongitude(61, 28);
            Latitude = decodeService.GetLatitude(89, 27);
            COG = decodeService.GetCourseOverGround(116, 12);
            HDG = decodeService.GetTrueHeading();
            Timestamp = decodeService.GetInt16(137, 6);
            Maneuver = decodeService.GetManeuverIndicator();
            RAIM = decodeService.GetRAIMFlag(148, 1);
            Spare = decodeService.GetInt16(145, 3);
            RadioStatus = decodeService.GetInt32(149, 19);
        }

        public MessageType1()
        {
        }
    }

}
