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

        public IEnumerable<Message> GetAllMessages()
        {
            try
            {
                return _ctx.Messages.OrderBy(p => p.Id).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Failed to get all messages: {ex}");
                return null;
            }
        }

        public void AddMessages(IEnumerable<Message> messages)
        {
            try
            {
                _ctx.AddRange(messages);
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
