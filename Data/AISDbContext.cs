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
        //public DbSet<MessageType123> MessagesType123 { get; set; }
        public DbSet<MessageType1> MessagesType1 { get; set; }
        public DbSet<MessageType2> MessagesType2 { get; set; }
        public DbSet<MessageType3> MessagesType3 { get; set; }
        public DbSet<MessageType4> MessagesType4 { get; set; }
        public DbSet<MessageType5> MessagesType5 { get; set; }
        public DbSet<MessageType9> MessagesType9 { get; set; }
        public DbSet<MessageType21> MessagesType21 { get; set; }

        public AISDbContext(DbContextOptions<AISDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MessageType1>()
                .HasDiscriminator<string>("Type")
                .HasValue<MessageType1>("1")
                .HasValue<MessageType2>("2")
                .HasValue<MessageType3>("3");
        }
    }
}
