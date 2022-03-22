using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;
using TempleTours.Models.ViewModels;

namespace TempleTours.Controllers
{
    public class HomeController : Controller
    {
        private TempleToursContext templeContext { get; set; }

        public HomeController(TempleToursContext tours)
        {
            templeContext = tours;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var x = new TimeSlotsViewModel
            {
                TimeSlots = templeContext.TimeSlots
            };

            return View(x);
        }


        //////// Start \\\\\\\\
        

        //Todo: Change
        [HttpPost]
        public IActionResult SignUp(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                //Pass a time slot appointment
                return View("SignUpForm", appt);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        public IActionResult SignUpForm(int id)
        {
            //Edit or Create
            var timeslot = templeContext.TimeSlots.Single(x => x.TimeSlotId ==id);
            return View("SignUpForm", new Appointment { AppointmentTimeSlot = timeslot});
        }

        [HttpPost]
        public IActionResult SignUpForm(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                templeContext.Add(appt);
                templeContext.SaveChanges();

                return View("Index");
            }
            else
            {
                //Not sure. I think we send the same thing as the get. 
                return View("SignUpForm",appt.AppointmentTimeSlot.TimeSlotId);
            }
        }


        //Make sure to add edit and delete functionality for appointments.
        //////// END \\\\\\\\
        [HttpGet]
        public IActionResult Appointments()
        {
            var times = templeContext.Appointments
                .OrderBy(x => x.AppointmentTimeSlot.TimeSlotStart)
                .ToList();

            return View("Appointments",  times);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            templeContext.Appointments.Single(x => x.AppointmentId == id);
            return View("SignUpForm");
        }

        [HttpPost]
        public IActionResult Edit (Appointment appt)
        {
            if (ModelState.IsValid)
            {
                templeContext.Update(appt);
                templeContext.SaveChanges();

                return View("Appointments", appt);
            }
            else
            {
                return RedirectToAction("SighUpForm", new { id = appt.AppointmentId });
            }
        }
    }
}
