using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    interface ITempleToursRepository
    {
        IQueryable<TimeSlot> TimeSlots { get; }

        public void SaveTimeSlot(TimeSlot t);

        public void CreateTimeSlot(TimeSlot t);

        public void DeleteTimeSlot(TimeSlot t);
    }
}
