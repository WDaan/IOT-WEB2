using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2__Razer_.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2__Razer_.Controllers
{
    public class HomeController : Controller
    {
        //TODO 02: Homecontroller maken

        public ViewResult Index()
        {
                List<Electricstep> steps = new List<Electricstep>() {
                new Electricstep() {
                ID = 1,
                Location = new Coordinates() { Latitude=12.5876, Longitude=27.6472, Altitude=0 },
                Type = "Turbo 2.0",
                PricePerHour = 3.5,
                LastRented= new DateTime()
                }
            };

            //steps meegeven aan view
            return View(steps);
        }
    }
}
