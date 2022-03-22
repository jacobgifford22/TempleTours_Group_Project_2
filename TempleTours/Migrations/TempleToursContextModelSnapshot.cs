﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleTours.Models;

namespace TempleTours.Migrations
{
    [DbContext(typeof(TempleToursContext))]
    partial class TempleToursContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("TempleTours.Models.Appointment", b =>
                {
                    b.Property<long>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

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

                    b.Property<int>("TimeSlotId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentId");

                    b.HasIndex("TimeSlotId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("TempleTours.Models.TimeSlot", b =>
                {
                    b.Property<int>("TimeSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TimeSlotDay")
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeSlotStart")
                        .HasColumnType("INTEGER");

                    b.HasKey("TimeSlotId");

                    b.ToTable("TimeSlots");

                    b.HasData(
                        new
                        {
                            TimeSlotId = 1,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 2,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 3,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 4,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 5,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 6,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 7,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 8,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 9,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 10,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 11,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 12,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 13,
                            Available = true,
                            TimeSlotDay = "Monday",
                            TimeSlotStart = 20
                        },
                        new
                        {
                            TimeSlotId = 14,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 15,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 16,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 17,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 18,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 19,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 20,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 21,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 22,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 23,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 24,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 25,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 26,
                            Available = true,
                            TimeSlotDay = "Tuesday",
                            TimeSlotStart = 20
                        },
                        new
                        {
                            TimeSlotId = 27,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 28,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 29,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 30,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 31,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 32,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 33,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 34,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 35,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 36,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 37,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 38,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 39,
                            Available = true,
                            TimeSlotDay = "Wednesday",
                            TimeSlotStart = 20
                        },
                        new
                        {
                            TimeSlotId = 40,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 41,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 42,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 43,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 44,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 45,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 46,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 47,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 48,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 49,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 50,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 51,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 52,
                            Available = true,
                            TimeSlotDay = "Thursday",
                            TimeSlotStart = 20
                        },
                        new
                        {
                            TimeSlotId = 53,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 54,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 55,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 56,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 57,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 58,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 59,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 60,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 61,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 62,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 63,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 64,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 65,
                            Available = true,
                            TimeSlotDay = "Friday",
                            TimeSlotStart = 20
                        },
                        new
                        {
                            TimeSlotId = 66,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 67,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 68,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 69,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 70,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 71,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 72,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 73,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 74,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 75,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 76,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 77,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 78,
                            Available = true,
                            TimeSlotDay = "Saturday",
                            TimeSlotStart = 20
                        },
                        new
                        {
                            TimeSlotId = 79,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 8
                        },
                        new
                        {
                            TimeSlotId = 80,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 9
                        },
                        new
                        {
                            TimeSlotId = 81,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 10
                        },
                        new
                        {
                            TimeSlotId = 82,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 11
                        },
                        new
                        {
                            TimeSlotId = 83,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 12
                        },
                        new
                        {
                            TimeSlotId = 84,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 13
                        },
                        new
                        {
                            TimeSlotId = 85,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 14
                        },
                        new
                        {
                            TimeSlotId = 86,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 15
                        },
                        new
                        {
                            TimeSlotId = 87,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 16
                        },
                        new
                        {
                            TimeSlotId = 88,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 17
                        },
                        new
                        {
                            TimeSlotId = 89,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 18
                        },
                        new
                        {
                            TimeSlotId = 90,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 19
                        },
                        new
                        {
                            TimeSlotId = 91,
                            Available = true,
                            TimeSlotDay = "Sunday",
                            TimeSlotStart = 20
                        });
                });

            modelBuilder.Entity("TempleTours.Models.Appointment", b =>
                {
                    b.HasOne("TempleTours.Models.TimeSlot", "TimeSlot")
                        .WithMany()
                        .HasForeignKey("TimeSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
