﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleTours.Models;

namespace TempleTours.Migrations
{
    [DbContext(typeof(TempleToursContext))]
    [Migration("20220315223024_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("TempleTours.Models.Appointment", b =>
                {
                    b.Property<long>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppointmentTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("TempleTours.Models.TimeSlot", b =>
                {
                    b.Property<long>("TimeSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TimeSlotStart")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeSlotId");

                    b.ToTable("TimeSlots");

                    b.HasData(
                        new
                        {
                            TimeSlotId = 1L,
                            TimeSlotStart = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 2L,
                            TimeSlotStart = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 3L,
                            TimeSlotStart = "10:00 AM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
