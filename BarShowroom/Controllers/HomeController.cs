using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(barShowroomMenu);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        static List<BarShowroomMenuItem> barShowroomMenu = new List<BarShowroomMenuItem>
        {
            new BarShowroomMenuItem{
                Name = "Bars",
                Title = "Check our bars out",
                Action = "~/Views/Bars"
            },
            new BarShowroomMenuItem{
                Name = "Beers",
                Title = "Browse beers",
                Action = "~/Views/Beers"
            },
            new BarShowroomMenuItem{
                Name = "Breweries",
                Title = "Pick your brewery",
                Action = "~/Views/Breweries"
            }
        };
    }
}
