using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType4 : Message
    {
        public DateTime? Date { get; set; }
        public string FixQuality { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string FixType { get; set; }
        public string RAIM { get; set; }
    }
}
