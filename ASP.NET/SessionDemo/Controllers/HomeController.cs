using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers
{
    //TODO 06: Controller code aanmaken
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            IncrementPageCounter();

            return View();
        }

        private void IncrementPageCounter()
        {
            Int32 counter = 0;

            //pagina teller met 1 verhogen
            if (HttpContext.Session.GetInt32("PageCounter") != null)
                counter = Convert.ToInt32(HttpContext.Session.GetInt32("PageCounter"));
                
            
                counter++;
                HttpContext.Session.SetInt32("PageCounter", counter);
            

            ViewBag.PageCounter = HttpContext.Session.GetInt32("PageCounter");
        }

        [HttpPost]
        public ViewResult Index(Login loginData)
        {
            IncrementPageCounter();

            if (ModelState.IsValid)
            {
                //login valid
                if (loginData.Email == "daan@vives.be" && loginData.Password == "test")
                {
                    HttpContext.Session.SetString("LoggedIn", "true");
                    return View("Secret");
                }
                else
                {
                    //no valid login
                    HttpContext.Session.SetString("LoggedIn", "false");
                    return View("WrongLogin");
                }
            }
            else
            {
                return View();
            }
        }

        public ViewResult OtherPage()
        {
            IncrementPageCounter();
            return View();
        }

        public ViewResult Secret()
        {
            IncrementPageCounter();
            return View();
        }

        public ViewResult WrongLogin()
        {
            IncrementPageCounter();
            return View();
        }

        public ViewResult Logout()
        {
            HttpContext.Session.Clear();
            IncrementPageCounter();
            return View("Index");
        }

    }
}
