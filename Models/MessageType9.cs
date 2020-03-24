using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType9
    {
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        [Key]
        public Int64 MMSI { get; set; }
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
        public string Country { get; set; }
    }
}
