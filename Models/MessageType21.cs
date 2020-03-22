﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class MessageType21 : Message
    {
        public string AidType { get; set; }
        public string Name { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string DimensionToBow { get; set; }
        public string DimensionToStern { get; set; }
        public string DimensionToPort { get; set; }
        public string DimensionToStarboard { get; set; }
        public string EPFD { get; set; }
        public string Second { get; set; }
        public string OffPosition { get; set; }
        public string RAIM { get; set; }
        public string VirtualAidFlag { get; set; }
        public string Assigned { get; set; }
    }
}
