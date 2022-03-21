using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models.ViewModels
{
    public class TimeSlotsViewModel
    {
        public IQueryable<TimeSlot> TimeSlots { get; set; }
    }
}
