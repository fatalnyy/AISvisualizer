using AISvisualizer.Services;

namespace AISvisualizer.Models
{
    public class MessageType2 : MessageType1 
    {
        public MessageType2()
        {
        }

        public MessageType2(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
        }
    }

    public class MessageType2ViewModel : MessageType2
    {
        public MessageType5 MessageType5 { get; set; }
    }
}
