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

        [HttpPost]
        public IActionResult SignUp(Appointment appt)
        {
            if (ModelState.IsValid)
            {
                
                return View("SignUpForm", appt);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        public IActionResult SignUpForm()
        {
            ViewBag.Appointments = templeContext.Appointments.ToList();
            return View("SignUpForm");
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

                return RedirectToAction("SignUpForm", new { id = appt.AppointmentId });
            }
        }

        [HttpGet]
        public IActionResult Appointments()
        {
            var times = templeContext.Appointments
                .OrderBy(x => x.AppointmentTime)
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
