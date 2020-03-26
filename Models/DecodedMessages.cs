using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public class DecodedMessages
    {
        public List<MessageType1> MessagesType1 { get; set; } = new List<MessageType1>();
        public List<MessageType2> MessagesType2 { get; set; } = new List<MessageType2>();
        public List<MessageType3> MessagesType3 { get; set; } = new List<MessageType3>();
        public List<MessageType4> MessagesType4 { get; set; } = new List<MessageType4>();
        public List<MessageType5> MessagesType5 { get; set; } = new List<MessageType5>();
        public List<MessageType9> MessagesType9 { get; set; } = new List<MessageType9>();
        public List<MessageType21> MessagesType21 { get; set; } = new List<MessageType21>();
    }

    public class DecodedMessagesViewModel
    {
        public List<MessageType1ViewModel> MessagesType1 { get; set; } = new List<MessageType1ViewModel>();
        public List<MessageType2ViewModel> MessagesType2 { get; set; } = new List<MessageType2ViewModel>();
        public List<MessageType3ViewModel> MessagesType3 { get; set; } = new List<MessageType3ViewModel>();
        public List<MessageType4> MessagesType4 { get; set; } = new List<MessageType4>();
        public List<MessageType5> MessagesType5 { get; set; } = new List<MessageType5>();
        public List<MessageType9> MessagesType9 { get; set; } = new List<MessageType9>();
        public List<MessageType21> MessagesType21 { get; set; } = new List<MessageType21>();
    }
}
