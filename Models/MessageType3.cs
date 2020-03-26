using AISvisualizer.Services;

namespace AISvisualizer.Models
{
    public class MessageType3 : MessageType1
    {
        public MessageType3()
        {
        }

        public MessageType3(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
        }
    }

    public class MessageType3ViewModel : MessageType3
    {
        public MessageType5 MessageType5 { get; set; }
    }
}
