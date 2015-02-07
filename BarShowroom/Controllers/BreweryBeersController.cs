using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BreweryBeersController : Controller
    {
        //
        // GET: /BreweryBeers/
        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index(string breweryname)
        {
            var beers = _db.Beers.Include("Brewery").Where(s => s.Brewery.Name == breweryname).OrderBy(s=>s.Name).ToList();
            ViewBag.brewery = breweryname;
            return View(beers);
        }

        //
        // GET: /BreweryBeers/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BreweryBeers/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BreweryBeers/Create

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
        // GET: /BreweryBeers/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BreweryBeers/Edit/5

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
        // GET: /BreweryBeers/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BreweryBeers/Delete/5

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
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
