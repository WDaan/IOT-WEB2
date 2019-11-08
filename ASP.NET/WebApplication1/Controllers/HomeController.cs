using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

//TODO 03: Controller aanmaken.

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}



        //Versie 1
        //public ViewResult Index()
        //{
        //    return View(new string[] { "C#", "Vives", "ICT" });
        //}


        //Versie 2

        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();

        //    foreach (Product p in Product.GetProducts())
        //    {
        //        //Gebruik de 'null conditional operator' om 
        //        //null reference exceptions te vermijden...
        //        string name = p?.Name;
        //        decimal? price = p?.Price;
        //        string relatedName = p?.Related?.Name;

        //        results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
        //    }

        //    //Geef een IEnumerable mee naar de View Index...
        //    return View(results);
        //}


        //Versie 3
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                //Gebruik de 'coalescing operator' om een 'fallback waarde'
                //te voorzien.
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";

                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }

            //Geef een IEnumerable mee naar de View Index...
            return View(results);
        }
    }
}
