using AISvisualizer.Models;
using System.Collections.Generic;

namespace AISvisualizer.Data
{
    public interface IAISRepository
    {
        void AddMessages(DecodedMessages messages);
        IEnumerable<T> GetAllMessages<T>() where T : class;
        bool SaveAll();
    }
}