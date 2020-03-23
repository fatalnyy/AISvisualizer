using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class DecodedMessages
    {
        public List<MessageType123> MessageType123s { get; set; } = new List<MessageType123>();
        public List<MessageType4> MessageType4s { get; set; } = new List<MessageType4>();
        public List<MessageType5> MessageType5s { get; set; } = new List<MessageType5>();
        public List<MessageType9> MessageType9s { get; set; } = new List<MessageType9>();
        public List<MessageType21> MessageType21s { get; set; } = new List<MessageType21>();
    }
}
