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
        [Required(ErrorMessage ="Please enter a group name.")]
        public string GroupName { get; set; }
        [Required(ErrorMessage ="Please make sure your group is no larger than 15 people.")]
        [Range(1, 15)]
        public int GroupSize { get; set; }
        [Required(ErrorMessage ="Please enter an email address.")]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
