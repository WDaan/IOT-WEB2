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
            Product product = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person.",
                Category = "Watersports",
                Price = 275M
            };

            //Gebruik het standaard 'overkoepelend' object
            //en voeg zelf properties toe... Zoals StockLevel.
            ViewBag.StockLevel = 2;

            //product meegeven aan view
            return View(product);
        }
    }
}
