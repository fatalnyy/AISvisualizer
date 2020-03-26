using AISvisualizer.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Data
{
    public class AISRepository : IAISRepository
    {
        private readonly AISDbContext _ctx;
        private readonly ILogger<AISRepository> _logger;
        public AISRepository(AISDbContext ctx, ILogger<AISRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<T> GetAllMessages<T>() where T : class
        {
            try
            {
                return _ctx.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Failed to get all messages {ex}");
                return null;
            }
        }

        public void AddMessages(DecodedMessages messages)
        {
            try
            {
                _ctx.AddRange(messages.MessagesType1);
                _ctx.AddRange(messages.MessagesType2);
                _ctx.AddRange(messages.MessagesType3);
                _ctx.AddRange(messages.MessagesType4);
                _ctx.AddRange(messages.MessagesType5);
                _ctx.AddRange(messages.MessagesType9);
                _ctx.AddRange(messages.MessagesType21);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Failed to add decoded messages: {ex}");
            }
        }
        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
