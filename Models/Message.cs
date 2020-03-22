using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        public Int64 MMSI { get; set; }

    }
    
    public class MessageType1 : Message
    {
        public string Status { get; set; }
        public Int16? ROT { get; set; }
        public double? SOG { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? COG { get; set; }
        public Int16? HDG { get; set; }
        public string Timestamp { get; set; }
        public string Maneuver { get; set; }
        public string RAIM { get; set; }
    }

    public class MessageType2 : MessageType1 { }
    public class MessageType3 : MessageType2 { }
}
