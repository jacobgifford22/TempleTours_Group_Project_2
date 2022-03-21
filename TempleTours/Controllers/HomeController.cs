using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;

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
            return View();
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
            return View();
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
                return View("Index");
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
    }
}
