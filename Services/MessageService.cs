using AISvisualizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public class MessageService : IMessageService
    {
        private readonly IDecodeService _decodeService;
        private readonly IExtractService _extractService;
        int counter = 0;
        public string BinaryPayload { get; set; }
        public string FragmentOfPayload { get; set; }
        public string EncodedPayload { get; set; }

        public MessageService(IDecodeService decodeService, IExtractService extractService)
        {
            _decodeService = decodeService;
            _extractService = extractService;
        }

        public async Task<DecodedMessages> GetDecodedMessage(IAsyncEnumerable<LineContent> lineContents)
        {
            var decodedMessages = new DecodedMessages();

            await foreach (var lineContent in lineContents)
            {
                var numSentences = Convert.ToInt32(lineContent.AISsentence.MessageCount);
                var numFillBits = Convert.ToInt32(lineContent.AISsentence.Size.Substring(0, 1));
                var fragmentNumber = Convert.ToInt32(lineContent.AISsentence.MessageNumber);

                if (numSentences > 1 && fragmentNumber == 1)
                {
                    FragmentOfPayload = lineContent.AISsentence.Payload;
                    continue;
                }

                if (numSentences > 1 && fragmentNumber == 2)
                    EncodedPayload = FragmentOfPayload + lineContent.AISsentence.Payload;
                else
                    EncodedPayload = lineContent.AISsentence.Payload;

                BinaryPayload = _extractService.GetBinaryPayload(EncodedPayload, numFillBits);
                if (string.IsNullOrWhiteSpace(BinaryPayload)) continue;

                _decodeService.BinaryPayload = BinaryPayload;
                _decodeService.Packet = lineContent.AISsentence.Format.Substring(1);
                _decodeService.Channel = lineContent.AISsentence.Channel;
                _decodeService.Date = DateTime.Parse(string.Format("{0} {1}", lineContent.Date, lineContent.Time));
                _decodeService.MMSI = _decodeService.GetInt64(8, 30);

                if (_decodeService.MMSI <= 99999999)
                {
                    //if (_decodeService.GetMessageType() > 3 && _decodeService.MMSI >= 999) counter++;
                    //else continue;
                    counter++;
                    continue;
                }
                var messageType = _decodeService.GetMessageType();

                if (messageType > 0)
                {
                    switch (messageType)
                    {
                        case (Int16)Enums.Enums.MessageTypes.MessageType1:
                            MessageType1 messageType1 = new MessageType1(messageType, _decodeService);
                            decodedMessages.MessagesType1.Add(messageType1);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType2:
                            MessageType2 messageType2 = new MessageType2(messageType, _decodeService);
                            decodedMessages.MessagesType2.Add(messageType2);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType3:
                            MessageType3 messageType3 = new MessageType3(messageType, _decodeService);
                            decodedMessages.MessagesType3.Add(messageType3);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType4:
                            MessageType4 messageType4 = new MessageType4(messageType, _decodeService);
                            decodedMessages.MessagesType4.Add(messageType4);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType5:
                            MessageType5 messageType5 = new MessageType5(messageType, _decodeService);
                            decodedMessages.MessagesType5.Add(messageType5);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType9:
                            MessageType9 messageType9 = new MessageType9(messageType, _decodeService);
                            decodedMessages.MessagesType9.Add(messageType9);
                            break;
                        case (Int16)Enums.Enums.MessageTypes.MessageType21:
                            MessageType21 messageType21 = new MessageType21(messageType, _decodeService);
                            decodedMessages.MessagesType21.Add(messageType21);
                            break;
                        default:
                            continue;
                    }
                }
                else
                    continue;
            }
            return decodedMessages;
        }
    }
}
