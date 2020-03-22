using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class DecodedMessages
    {
        public List<MessageType1> MessageType1s { get; set; } = new List<MessageType1>();
        public List<MessageType2> MessageType2s { get; set; } = new List<MessageType2>();
        public List<MessageType3> MessageType3s { get; set; } = new List<MessageType3>();
        public List<MessageType4> MessageType4s { get; set; } = new List<MessageType4>();
        public List<MessageType5> MessageType5s { get; set; } = new List<MessageType5>();
        public List<MessageType9> MessageType9s { get; set; } = new List<MessageType9>();
        public List<MessageType21> MessageType21s { get; set; } = new List<MessageType21>();
    }
}
