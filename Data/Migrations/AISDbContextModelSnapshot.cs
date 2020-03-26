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

            modelBuilder.Entity("AISvisualizer.Models.MessageType1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accuracy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("COG")
                        .HasColumnType("float");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<short?>("HDG")
                        .HasColumnType("smallint");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("Maneuver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ROT")
                        .HasColumnType("float");

                    b.Property<int>("RadioStatus")
                        .HasColumnType("int");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<double?>("SOG")
                        .HasColumnType("float");

                    b.Property<short>("Spare")
                        .HasColumnType("smallint");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Timestamp")
                        .HasColumnType("smallint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MessagesType1");

                    b.HasDiscriminator<string>("Type").HasValue("1");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType21", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<short>("DimensionToBow")
                        .HasColumnType("smallint");

                    b.Property<short>("DimensionToPort")
                        .HasColumnType("smallint");

                    b.Property<short>("DimensionToStarboard")
                        .HasColumnType("smallint");

                    b.Property<short>("DimensionToStern")
                        .HasColumnType("smallint");

                    b.Property<string>("EPFD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

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

                    b.Property<short>("Reserved")
                        .HasColumnType("smallint");

                    b.Property<short>("Second")
                        .HasColumnType("smallint");

                    b.Property<short>("Spare")
                        .HasColumnType("smallint");

                    b.Property<string>("VirtualAidFlag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MessagesType21");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType4", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<short>("Day")
                        .HasColumnType("smallint");

                    b.Property<string>("EPFD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FixQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Hour")
                        .HasColumnType("smallint");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Minute")
                        .HasColumnType("smallint");

                    b.Property<short>("Month")
                        .HasColumnType("smallint");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RadioStatus")
                        .HasColumnType("int");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<short>("Second")
                        .HasColumnType("smallint");

                    b.Property<short>("Spare")
                        .HasColumnType("smallint");

                    b.Property<short>("Year")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MessagesType4");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType5", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<short?>("Day")
                        .HasColumnType("smallint");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("DimensionToBow")
                        .HasColumnType("smallint");

                    b.Property<short>("DimensionToPort")
                        .HasColumnType("smallint");

                    b.Property<short>("DimensionToStarboard")
                        .HasColumnType("smallint");

                    b.Property<short>("DimensionToStern")
                        .HasColumnType("smallint");

                    b.Property<double>("Draught")
                        .HasColumnType("float");

                    b.Property<string>("EPFD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Hour")
                        .HasColumnType("smallint");

                    b.Property<long>("IMOnumber")
                        .HasColumnType("bigint");

                    b.Property<long>("MMSI")
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

                    b.Property<short>("Spare")
                        .HasColumnType("smallint");

                    b.Property<string>("VesselName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MessagesType5");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType9", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("MMSI")
                        .HasColumnType("bigint");

                    b.Property<string>("MessageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RadioStatus")
                        .HasColumnType("int");

                    b.Property<short>("Repeat")
                        .HasColumnType("smallint");

                    b.Property<short>("Reserved")
                        .HasColumnType("smallint");

                    b.Property<double?>("SOG")
                        .HasColumnType("float");

                    b.Property<short>("Spare")
                        .HasColumnType("smallint");

                    b.Property<short>("Timestamp")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MessagesType9");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType2", b =>
                {
                    b.HasBaseType("AISvisualizer.Models.MessageType1");

                    b.HasDiscriminator().HasValue("2");
                });

            modelBuilder.Entity("AISvisualizer.Models.MessageType3", b =>
                {
                    b.HasBaseType("AISvisualizer.Models.MessageType1");

                    b.HasDiscriminator().HasValue("3");
                });
#pragma warning restore 612, 618
        }
    }
}
