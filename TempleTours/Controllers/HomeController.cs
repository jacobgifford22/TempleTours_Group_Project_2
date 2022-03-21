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

        public IActionResult SignUp()
        {
            return View();
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
    }
}
