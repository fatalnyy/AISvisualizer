using AISvisualizer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType5 : Message
    {
        public string AISversion { get; set; }
        public Int64 IMOnumber { get; set; }
        public string CallSign { get; set; }
        public string VesselName { get; set; }
        public string ShipType { get; set; }
        public Int16 DimensionToBow { get; set; }
        public Int16 DimensionToStern { get; set; }
        public Int16 DimensionToPort { get; set; }
        public Int16 DimensionToStarboard { get; set; }
        public string EPFD { get; set; }
        public Int16? Month { get; set; }
        public Int16? Day { get; set; }
        public Int16? Hour { get; set; }
        public Int16? Minute { get; set; }
        public double Draught { get; set; }
        public string Destination { get; set; }
        public Int16 Spare { get; set; }
        public string DTE { get; set; }

        public MessageType5(short messageType, IDecodeService decodeService) 
            : base(messageType, decodeService)
        {
            AISversion = decodeService.GetAISversion();
            IMOnumber = decodeService.GetInt64(40, 30);
            CallSign = decodeService.GetString(70, 42);
            VesselName = decodeService.GetString(112, 120);
            ShipType = decodeService.GetShipType();
            DimensionToBow = decodeService.GetInt16(240, 9);
            DimensionToStern = decodeService.GetInt16(249, 9);
            DimensionToPort = decodeService.GetInt16(258, 6);
            DimensionToStarboard = decodeService.GetInt16(264, 6);
            EPFD = decodeService.GetEPFD(270, 4);
            Month = decodeService.GetPartOfDate(274, 4, true);
            Day = decodeService.GetPartOfDate(278, 5, false, true);
            Hour = decodeService.GetPartOfDate(283, 5, false, false, true);
            Minute = decodeService.GetPartOfDate(288, 6, false, false, false, true);
            Draught = decodeService.GetDraught(294, 8);
            Destination = decodeService.GetString(302, 120);
            DTE = decodeService.GetDTE(422, 1);
        }

        public MessageType5()
        {
        }
    }
}
