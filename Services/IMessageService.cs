using AISvisualizer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public interface IMessageService
    {
        string BinaryPayload { get; set; }
        string EncodedPayload { get; set; }
        string FragmentOfPayload { get; set; }

        Task<DecodedMessages> GetDecodedMessage(IAsyncEnumerable<LineContent> lineContents);
    }
}