using AISvisualizer.Models;
using System.Collections.Generic;

namespace AISvisualizer.Data
{
    public interface IAISRepository
    {
        IEnumerable<Message> GetAllMessages();
        void AddMessages(IEnumerable<Message> messages);
        bool SaveAll();
    }
}