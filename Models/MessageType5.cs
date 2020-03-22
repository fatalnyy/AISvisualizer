using System;
using System.Collections.Generic;
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
        public string DimensionToBow { get; set; }
        public string DimensionToStern { get; set; }
        public string DimensionToPort { get; set; }
        public string DimensionToStarboard { get; set; }
        public string EPFD { get; set; }
        public Int16? Month { get; set; }
        public Int16? Day { get; set; }
        public Int16? Hour { get; set; }
        public Int16? Minute { get; set; }
        public double Draught { get; set; }
        public string Destination { get; set; }
        public string DTE { get; set; }
    }
}
