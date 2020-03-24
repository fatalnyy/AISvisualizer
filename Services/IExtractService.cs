using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public interface IExtractService
    {
        IEnumerable<byte> GetProcessedASCII(string payload);
        string GetBinaryPayload(string payload, int numFillBits);
        string ExtractBinaryFieldValue(string binaryPayload, int startIndex, int length);
    }
}
