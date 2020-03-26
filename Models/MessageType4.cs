using AISvisualizer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType4 : Message
    {
        public string FixQuality { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string EPFD { get; set; }
        public string RAIM { get; set; }
        public Int16 Spare { get; set; }
        public int RadioStatus { get; set; }

        public MessageType4(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
            FixQuality = decodeService.GetPositionAccuracy(78, 1);
            Longitude = decodeService.GetLongitude(79, 28);
            Latitude = decodeService.GetLatitude(107, 27);
            EPFD = decodeService.GetEPFD(134, 4);
            RAIM = decodeService.GetRAIMFlag(148, 1);
        }

        public MessageType4()
        {
        }
    }
}
