using AISvisualizer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType9 : Message
    {
        public string Altitude { get; set; }
        public double? SOG { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? COG { get; set; }
        public Int16 Timestamp { get; set; }
        public Int16 Reserved { get; set; }
        public string DTE { get; set; }
        public string Assigned { get; set; }
        public string RAIM { get; set; }
        public Int16 Spare { get; set; }
        public int RadioStatus { get; set; }

        public MessageType9(short messageType, IDecodeService decodeService) 
            : base(messageType, decodeService)
        {
            Altitude = decodeService.GetAltitude(38, 12);
            SOG = decodeService.GetSpeedOverGround(50, 10);
            Accuracy = decodeService.GetPositionAccuracy(60, 1);
            Longitude = decodeService.GetLongitude(61, 28);
            Latitude = decodeService.GetLatitude(89, 2);
            COG = decodeService.GetCourseOverGround(116, 12);
            Timestamp = decodeService.GetInt16(128, 6);
            DTE = decodeService.GetDTE(142, 1);
            Assigned = decodeService.GetAssinged(146, 1);
            RAIM = decodeService.GetRAIMFlag(147, 1);
            Spare = decodeService.GetInt16(143, 3);
            RadioStatus = decodeService.GetInt32(148, 20);
            Reserved = decodeService.GetInt16(134, 8);
        }

        public MessageType9()
        {
        }
    }
}
