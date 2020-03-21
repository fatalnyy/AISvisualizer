using AISvisualizer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Data
{
    public class AISDbContext : DbContext
    {
        public AISDbContext(DbContextOptions<AISDbContext> options)
            : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
    }
}
