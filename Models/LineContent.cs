using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class LineContent
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public AISsentence AISsentence { get; set; }
    }
}
