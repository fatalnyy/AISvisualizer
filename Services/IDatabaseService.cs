using AISvisualizer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace AISvisualizer.Services
{
    public interface IDatabaseService
    {
        DataTable GetDataTableParameter(IEnumerable<MessageType1> messages, int type);
        DataTable GetDataTableParameter(IEnumerable<MessageType21> messages);
        DataTable GetDataTableParameter(IEnumerable<MessageType4> messages);
        DataTable GetDataTableParameter(IEnumerable<MessageType5> messages);
        DataTable GetDataTableParameter(IEnumerable<MessageType9> messages);
        long RunPrcDataTableType(string iud, string prc_name, DataTable dt);
        void SaveDecodedMessages(DecodedMessages decodedMessages);
    }
}