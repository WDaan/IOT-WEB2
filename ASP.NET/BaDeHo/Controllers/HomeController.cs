using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaDeHo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


    //TODO 12: Add HomeController

namespace BaDeHo.Controllers
{
    public class HomeController : Controller
    {
        Opslagplaats opslagplaats = new Opslagplaats();

        public ViewResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Date = DateTime.Now;
            ViewBag.ActivePage = "Home";

            return View();
        }

        public ViewResult Broden()
        {
            ViewBag.Title = "Broden";
            ViewBag.Date = DateTime.Now;
            ViewBag.ActivePage = "Broden";

            //opslagplaats meegeven naar view


            return View(opslagplaats.MijnBroden);
        }

        public ViewResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Date = DateTime.Now;
            ViewBag.ActivePage = "Contact";

            return View();
        }

        //TODO 13: juiste mappenstructuur voor afbeeldingen en css
    }
}
