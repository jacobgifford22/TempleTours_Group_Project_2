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
        public long TimeSlotId { get; set; }
        public string TimeSlotStart { get; set; }
        public string TimeSlotDay { get; set; }
    }
}
