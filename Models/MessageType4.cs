using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType4
    {
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        [Key]
        public Int64 MMSI { get; set; }
        public DateTime? Date { get; set; }
        public string FixQuality { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string EPFD { get; set; }
        public string RAIM { get; set; }
        public string Country { get; set; }
    }
}
