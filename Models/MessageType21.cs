using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType21
    {
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        [Key]
        public Int64 MMSI { get; set; }

        public string Packet { get; set; }
        public string Channel { get; set; }
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
        public string RAIM { get; set; }
        public string VirtualAidFlag { get; set; }
        public string Assigned { get; set; }
        public string Country { get; set; }
    }
}
