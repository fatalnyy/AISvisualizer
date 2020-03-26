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
        public Int16 Year { get; set; }
        public Int16 Month { get; set; }
        public Int16 Day { get; set; }
        public Int16 Hour { get; set; }
        public Int16 Minute { get; set; }
        public Int16 Second { get; set; }
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
            Spare = decodeService.GetInt16(138, 10);
            RadioStatus = decodeService.GetInt32(149, 19);
            Year = decodeService.GetInt16(38, 14);
            Month = decodeService.GetInt16(52, 4);
            Day = decodeService.GetInt16(56, 5);
            Hour = decodeService.GetInt16(61, 5);
            Minute = decodeService.GetInt16(66, 6);
            Second = decodeService.GetInt16(72, 6);
        }

        public MessageType4()
        {
        }
    }
}
