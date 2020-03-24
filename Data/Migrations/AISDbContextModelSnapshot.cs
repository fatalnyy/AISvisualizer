﻿// <auto-generated />
using System;
using AISvisualizer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AISvisualizer.Migrations
{
    [DbContext(typeof(AISDbContext))]
    partial class AISDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AISvisualizer.Models.MessageType123", b =>
                {
                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("Accuracy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("COG")
                        .HasColumnType("float");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("HDG")
                        .HasColumnType("smallint");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Maneuver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("ROT")
                        .HasColumnType("smallint");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<double?>("SOG")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timestamp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MMSI");

                    b.ToTable("MessagesType123");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType21", b =>
                {
                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("Accuracy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AidType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assigned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToBow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToStarboard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToStern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPFD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OffPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<string>("Second")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VirtualAidFlag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MMSI");

                    b.ToTable("MessagesType21");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType4", b =>
                {
                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EPFD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FixQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.HasKey("MMSI");

                    b.ToTable("MessagesType4");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType5", b =>
                {
                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("AISversion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallSign")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DTE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Day")
                        .HasColumnType("smallint");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToBow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToStarboard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionToStern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Draught")
                        .HasColumnType("float");

                    b.Property<string>("EPFD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Hour")
                        .HasColumnType("smallint");

                    b.Property<long>("IMOnumber")
                        .HasColumnType("bigint");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Minute")
                        .HasColumnType("smallint");

                    b.Property<short?>("Month")
                        .HasColumnType("smallint");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<string>("ShipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VesselName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MMSI");

                    b.ToTable("MessagesType5");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType9", b =>
                {
                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("Accuracy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Altitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assigned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("COG")
                        .HasColumnType("float");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DTE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<double?>("SOG")
                        .HasColumnType("float");

                    b.Property<string>("Timestamp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MMSI");

                    b.ToTable("MessagesType9");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType123", b =>
                {
                    b.HasOne("AISvisualizer.Models.MessageType5", "MessageType5")
                        .WithMany()
                        .HasForeignKey("MMSI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
