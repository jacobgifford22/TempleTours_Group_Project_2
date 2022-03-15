using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class EFTempleToursRepository : ITempleToursRepository
    {
        private TempleToursContext context { get; set; }

        public EFTempleToursRepository(TempleToursContext temp) => context = temp;

        public IQueryable<TimeSlot> TimeSlots => context.TimeSlots;

        public void SaveTimeSlot(TimeSlot t)
        {
            context.SaveChanges();
        }

        public void CreateTimeSlot(TimeSlot t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void DeleteTimeSlot(TimeSlot t)
        {
            context.Remove(t);
            context.SaveChanges();
        }
    }
}
