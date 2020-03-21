using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class AISmessage
    {
        public string Format { get; set; }
        public string MessageCount { get; set; }
        public string MessageNumber { get; set; }
        public string SequenceId { get; set; }
        public string Channel { get; set; }
        public string Payload { get; set; }
        public string Size { get; set; }
    }
}
