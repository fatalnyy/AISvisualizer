using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    //public class Message
    //{
    //    public int Id { get; set; }
    //    public string MessageType { get; set; }
    //    public Int16 Repeat { get; set; }
    //    public Int64 MMSI { get; set; }
    //    public string Status { get; set; }
    //    public Int16? ROT { get; set; }
    //    public double? SOG { get; set; }
    //    public string Accuracy { get; set; }
    //    public double Longitude { get; set; }
    //    public double Latitude { get; set; }
    //    public double? COG { get; set; }
    //    public Int16? HDG { get; set; }
    //    public string Timestamp { get; set; }
    //    public string Maneuver { get; set; }
    //    public string RAIM { get; set; }

    //}
    
    public class MessageType123
    {
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        [Key]
        public Int64 MMSI { get; set; }
        public string Packet { get; set; }
        public string Channel { get; set; }
        public string Status { get; set; }
        public double? ROT { get; set; }
        public double? SOG { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? COG { get; set; }
        public Int16? HDG { get; set; }
        public Int16 Timestamp { get; set; }
        public string Maneuver { get; set; }
        public string RAIM { get; set; }
        public string Country { get; set; }

        [ForeignKey("MMSI")]
        public virtual MessageType5 MessageType5 { get; set; }
    }

    //public class MessageType2
    //{
    //    public int Id { get; set; }
    //    public string MessageType { get; set; }
    //    public Int16 Repeat { get; set; }
    //    public Int64 MMSI { get; set; }
    //    public string Status { get; set; }
    //    public Int16? ROT { get; set; }
    //    public double? SOG { get; set; }
    //    public string Accuracy { get; set; }
    //    public double Longitude { get; set; }
    //    public double Latitude { get; set; }
    //    public double? COG { get; set; }
    //    public Int16? HDG { get; set; }
    //    public string Timestamp { get; set; }
    //    public string Maneuver { get; set; }
    //    public string RAIM { get; set; }

    //    [ForeignKey("MMSI")]
    //    public virtual MessageType5 v_messageType5 { get; set; }
    //}
    //public class MessageType3 
    //{
    //    public int Id { get; set; }
    //    public string MessageType { get; set; }
    //    public Int16 Repeat { get; set; }
    //    public Int64 MMSI { get; set; }
    //    public string Status { get; set; }
    //    public Int16? ROT { get; set; }
    //    public double? SOG { get; set; }
    //    public string Accuracy { get; set; }
    //    public double Longitude { get; set; }
    //    public double Latitude { get; set; }
    //    public double? COG { get; set; }
    //    public Int16? HDG { get; set; }
    //    public string Timestamp { get; set; }
    //    public string Maneuver { get; set; }
    //    public string RAIM { get; set; }

    //    [ForeignKey("MMSI")]
    //    public virtual MessageType5 v_messageType5 { get; set; }
    //}
}
