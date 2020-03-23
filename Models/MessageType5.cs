﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType5
    {
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        [Key]
        public Int64 MMSI { get; set; }
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