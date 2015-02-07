using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BreweryBarsController : Controller
    {
        //
        // GET: /BreweryBars/

        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index(string breweryname)
        {
            var bars = _db.Bars.Include("Beers").Where(bar => bar.Beers.Where(be => be.Brewery.Name == breweryname).Count() > 1);
            ViewBag.breweryname = breweryname;
            return View(bars);
        }

        //
        // GET: /BreweryBars/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BreweryBars/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BreweryBars/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /BreweryBars/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BreweryBars/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /BreweryBars/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BreweryBars/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null) _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
