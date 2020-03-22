using System;
using System.Collections.Generic;
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
        public string Timestamp { get; set; }
        public string DTE { get; set; }
        public string Assigned { get; set; }
        public string RAIM { get; set; }
    }
}
