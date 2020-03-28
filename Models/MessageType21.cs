using AISvisualizer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType21 : Message
    {
        public string AidType { get; set; }
        public string Name { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Int16 DimensionToBow { get; set; }
        public Int16 DimensionToStern { get; set; }
        public Int16 DimensionToPort { get; set; }
        public Int16 DimensionToStarboard { get; set; }
        public string EPFD { get; set; }
        public Int16 Second { get; set; }
        public string OffPosition { get; set; }
        public Int16 Reserved { get; set; }
        public Int16 Spare { get; set; }
        public string RAIM { get; set; }
        public string VirtualAidFlag { get; set; }
        public string Assigned { get; set; }

        public MessageType21(short messageType, IDecodeService decodeService) 
            : base(messageType, decodeService)
        {
            AidType = decodeService.GetAidType();
            Name = decodeService.GetString(43, 120);
            Accuracy = decodeService.GetPositionAccuracy(163, 1);
            Longitude = decodeService.GetLongitude(164, 28);
            Latitude = decodeService.GetLatitude(192, 27);
            DimensionToBow = decodeService.GetInt16(219, 9);
            DimensionToStern = decodeService.GetInt16(228, 9);
            DimensionToPort = decodeService.GetInt16(237, 6);
            DimensionToStarboard = decodeService.GetInt16(243, 6);
            EPFD = decodeService.GetEPFD(249, 4);
            Second = decodeService.GetInt16(253, 6);
            OffPosition = decodeService.GetOffPositionIndicator();
            RAIM = decodeService.GetRAIMFlag(268, 1);
            VirtualAidFlag = decodeService.GetVirtualAidFlag();
            Assigned = decodeService.GetAssinged(270, 1);
            Spare = decodeService.GetInt16(271, 1);
            Reserved = decodeService.GetInt16(260, 8);
        }

        public MessageType21()
        {
        }
    }
}
