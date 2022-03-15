using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime;

namespace TempleTours.Models
{
    public class TempleToursContext : DbContext
    {
        public TempleToursContext()
        {
        }

        public TempleToursContext(DbContextOptions<TempleToursContext> options) : base(options)
        {
        }

        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { TimeSlotId = 1, TimeSlotStart = "8:00 AM" },
                new TimeSlot { TimeSlotId = 2, TimeSlotStart = "9:00 AM" },
                new TimeSlot { TimeSlotId = 3, TimeSlotStart = "10:00 AM" }
            );
        }
    }
}
