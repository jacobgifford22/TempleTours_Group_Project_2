using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTours.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public long AppointmentId { get; set; }
        public string AppointmentTime { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15)]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
