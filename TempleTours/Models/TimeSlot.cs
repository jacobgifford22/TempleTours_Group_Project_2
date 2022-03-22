using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotId { get; set; }
        public string TimeSlotDay { get; set; }
        public int TimeSlotStart { get; set; }
        public bool Available { get; set; }
    }
}
