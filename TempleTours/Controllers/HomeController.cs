using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Timeslot = templeContext.TimeSlots.Single(x => x.TimeSlotId ==id) ;
            var record = templeContext.TimeSlots.Single(x => x.TimeSlotId == id);
            return View("SignUpForm",new Appointment { TimeSlot = record, TimeSlotId = record.TimeSlotId});
        }

        [HttpPost]
        public IActionResult SignUpForm(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                templeContext.Add(appt);
                templeContext.SaveChanges();

                return View("Index", appt);
            }
            else
            {
                //Not sure. I think we send the same thing as the get. 
                var record = templeContext.TimeSlots.Single(x => x.TimeSlotId == appt.TimeSlotId);
                appt.TimeSlot = record;
                return View(appt);
            }
        }

        [HttpGet]
        public IActionResult Appointments()
        {
            var times = templeContext.Appointments
                .Include(x => x.TimeSlot)
                .OrderBy(x => x.TimeSlot.TimeSlotDay)
                .ThenBy(x => x.TimeSlot.TimeSlotStart)
                .ToList();

            return View("Appointments",  times);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            Appointment appt = templeContext.Appointments.Single(x => x.AppointmentId == id);
            var record = templeContext.TimeSlots.Single(x => x.TimeSlotId == appt.TimeSlotId);
            appt.TimeSlot = record;
            return View("SignUpForm", appt);
        }

        [HttpPost]
        public IActionResult Edit (Appointment appt)
        {
            if (ModelState.IsValid)
            {
                templeContext.Update(appt);
                templeContext.SaveChanges();
                return RedirectToAction("Appointments");
            }
            else
            {
                var record = templeContext.TimeSlots.Single(x => x.TimeSlotId == appt.TimeSlotId);
                appt.TimeSlot = record;
                return View("SignUpForm", appt);
            }
        }

        public IActionResult Delete(int id)
        {
            var appt = templeContext.Appointments.Single(x => x.AppointmentId == id);
            templeContext.Appointments.Remove(appt);
            templeContext.SaveChanges();
            return RedirectToAction("Appointments");
        }
    }
}
