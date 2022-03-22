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
                new TimeSlot { TimeSlotId = 1, TimeSlotDay = "Monday", TimeSlotStart = 8, Available=true },
                new TimeSlot { TimeSlotId = 2, TimeSlotDay = "Monday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 3, TimeSlotDay = "Monday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 4, TimeSlotDay = "Monday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 5, TimeSlotDay = "Monday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 6, TimeSlotDay = "Monday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 7, TimeSlotDay = "Monday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 8, TimeSlotDay = "Monday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 9, TimeSlotDay = "Monday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 10, TimeSlotDay = "Monday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 11, TimeSlotDay = "Monday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 12, TimeSlotDay = "Monday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 13, TimeSlotDay = "Monday", TimeSlotStart = 20, Available = true },
                new TimeSlot { TimeSlotId = 14, TimeSlotDay = "Tuesday", TimeSlotStart = 8, Available = true },
                new TimeSlot { TimeSlotId = 15, TimeSlotDay = "Tuesday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 16, TimeSlotDay = "Tuesday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 17, TimeSlotDay = "Tuesday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 18, TimeSlotDay = "Tuesday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 19, TimeSlotDay = "Tuesday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 20, TimeSlotDay = "Tuesday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 21, TimeSlotDay = "Tuesday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 22, TimeSlotDay = "Tuesday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 23, TimeSlotDay = "Tuesday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 24, TimeSlotDay = "Tuesday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 25, TimeSlotDay = "Tuesday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 26, TimeSlotDay = "Tuesday", TimeSlotStart = 20, Available = true },
                new TimeSlot { TimeSlotId = 27, TimeSlotDay = "Wednesday", TimeSlotStart = 8, Available = true },
                new TimeSlot { TimeSlotId = 28, TimeSlotDay = "Wednesday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 29, TimeSlotDay = "Wednesday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 30, TimeSlotDay = "Wednesday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 31, TimeSlotDay = "Wednesday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 32, TimeSlotDay = "Wednesday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 33, TimeSlotDay = "Wednesday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 34, TimeSlotDay = "Wednesday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 35, TimeSlotDay = "Wednesday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 36, TimeSlotDay = "Wednesday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 37, TimeSlotDay = "Wednesday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 38, TimeSlotDay = "Wednesday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 39, TimeSlotDay = "Wednesday", TimeSlotStart = 20, Available = true },
                new TimeSlot { TimeSlotId = 40, TimeSlotDay = "Thursday", TimeSlotStart = 8, Available = true },
                new TimeSlot { TimeSlotId = 41, TimeSlotDay = "Thursday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 42, TimeSlotDay = "Thursday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 43, TimeSlotDay = "Thursday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 44, TimeSlotDay = "Thursday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 45, TimeSlotDay = "Thursday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 46, TimeSlotDay = "Thursday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 47, TimeSlotDay = "Thursday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 48, TimeSlotDay = "Thursday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 49, TimeSlotDay = "Thursday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 50, TimeSlotDay = "Thursday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 51, TimeSlotDay = "Thursday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 52, TimeSlotDay = "Thursday", TimeSlotStart = 20, Available = true },
                new TimeSlot { TimeSlotId = 53, TimeSlotDay = "Friday", TimeSlotStart = 8, Available = true },
                new TimeSlot { TimeSlotId = 54, TimeSlotDay = "Friday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 55, TimeSlotDay = "Friday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 56, TimeSlotDay = "Friday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 57, TimeSlotDay = "Friday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 58, TimeSlotDay = "Friday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 59, TimeSlotDay = "Friday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 60, TimeSlotDay = "Friday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 61, TimeSlotDay = "Friday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 62, TimeSlotDay = "Friday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 63, TimeSlotDay = "Friday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 64, TimeSlotDay = "Friday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 65, TimeSlotDay = "Friday", TimeSlotStart = 20, Available = true },
                new TimeSlot { TimeSlotId = 66, TimeSlotDay = "Saturday", TimeSlotStart = 8, Available = true },
                new TimeSlot { TimeSlotId = 67, TimeSlotDay = "Saturday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 68, TimeSlotDay = "Saturday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 69, TimeSlotDay = "Saturday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 70, TimeSlotDay = "Saturday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 71, TimeSlotDay = "Saturday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 72, TimeSlotDay = "Saturday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 73, TimeSlotDay = "Saturday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 74, TimeSlotDay = "Saturday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 75, TimeSlotDay = "Saturday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 76, TimeSlotDay = "Saturday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 77, TimeSlotDay = "Saturday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 78, TimeSlotDay = "Saturday", TimeSlotStart = 20, Available = true },
                new TimeSlot { TimeSlotId = 79, TimeSlotDay = "Sunday", TimeSlotStart = 8, Available = true },
                new TimeSlot { TimeSlotId = 80, TimeSlotDay = "Sunday", TimeSlotStart = 9, Available = true },
                new TimeSlot { TimeSlotId = 81, TimeSlotDay = "Sunday", TimeSlotStart = 10, Available = true },
                new TimeSlot { TimeSlotId = 82, TimeSlotDay = "Sunday", TimeSlotStart = 11, Available = true },
                new TimeSlot { TimeSlotId = 83, TimeSlotDay = "Sunday", TimeSlotStart = 12, Available = true },
                new TimeSlot { TimeSlotId = 84, TimeSlotDay = "Sunday", TimeSlotStart = 13, Available = true },
                new TimeSlot { TimeSlotId = 85, TimeSlotDay = "Sunday", TimeSlotStart = 14, Available = true },
                new TimeSlot { TimeSlotId = 86, TimeSlotDay = "Sunday", TimeSlotStart = 15, Available = true },
                new TimeSlot { TimeSlotId = 87, TimeSlotDay = "Sunday", TimeSlotStart = 16, Available = true },
                new TimeSlot { TimeSlotId = 88, TimeSlotDay = "Sunday", TimeSlotStart = 17, Available = true },
                new TimeSlot { TimeSlotId = 89, TimeSlotDay = "Sunday", TimeSlotStart = 18, Available = true },
                new TimeSlot { TimeSlotId = 90, TimeSlotDay = "Sunday", TimeSlotStart = 19, Available = true },
                new TimeSlot { TimeSlotId = 91, TimeSlotDay = "Sunday", TimeSlotStart = 20, Available = true }
            );
        }
    }
}
