using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public class ExtractService : IExtractService
    {
        public IEnumerable<byte> GetProcessedASCII(string payload)
        {
            var asciiBytes = Encoding.ASCII.GetBytes(payload);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i] -= 48;

                if (asciiBytes[i] > 40) asciiBytes[i] -= 8;
                yield return asciiBytes[i];
            }
        }

        public string GetBinaryPayload(string payload)
        {
            var binaryPayload = new StringBuilder();
            var processedASCIIpayload = GetProcessedASCII(payload);

            foreach (var asciiByte in processedASCIIpayload)
            {
                var x = Convert.ToString(asciiByte, 2).PadLeft(6, '0');
                binaryPayload.Append(x);
            }
            return binaryPayload.ToString();
        }

        public string ExtractBinaryFieldValue(string binaryPayload, int startIndex, int length)
        {
            return binaryPayload.Substring(startIndex, length);
        }       
    }
}
