using AISvisualizer.Models;
using System.Collections.Generic;

namespace AISvisualizer.Data
{
    public interface IAISRepository
    {
        IEnumerable<MessageType123> GetAllMessages();
        void AddMessages(IEnumerable<MessageType5> messages);
        bool SaveAll();
    }
}