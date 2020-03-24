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
        //public DbSet<MessageType4> MessagesType4 { get; set; }
        //public DbSet<MessageType5> MessagesType5 { get; set; }
        //public DbSet<MessageType9> MessagesType9 { get; set; }
        //public DbSet<MessageType21> MessagesType21 { get; set; }

        public AISDbContext(DbContextOptions<AISDbContext> options)
            : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<MessageType123>().Property(a => a.MMSI).ValueGeneratedNever();
        //    //modelBuilder.Entity<MessageType4>().Property(a => a.MMSI).ValueGeneratedNever();
        //    //modelBuilder.Entity<MessageType5>().Property(a => a.MMSI).ValueGeneratedNever();
        //    //modelBuilder.Entity<MessageType9>().Property(a => a.MMSI).ValueGeneratedNever();
        //    //modelBuilder.Entity<MessageType21>().Property(a => a.MMSI).ValueGeneratedNever();
        //}
    }
}
