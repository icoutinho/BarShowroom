using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BarBeersController : Controller
    {
        //
        // GET: /BarBeers/
        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index(string barname)
        {
            var dbbar = _db.Bars.Include("Beers").Single(b => b.Name == barname);
            ViewBag.bar = dbbar.Name;
            return View(dbbar.Beers.OrderBy(b=>b.Name).ToList());
        }

        //
        // GET: /BarBeers/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BarBeers/Create

        public ActionResult Create(string barname)
        {
            ViewBag.bar = barname;
            return View();
        }

        //
        // POST: /BarBeers/Create

        [HttpPost]
        public ActionResult Create(string barname, BarBeer barbeer)
        {
            if (ModelState.IsValid)
            {
                var beer = _db.Beers.Include("Bars").Single(s => s.Name == barbeer.Name);
                var bar = _db.Bars.Include("Beers").Single(s => s.Name == barname);
                beer.Bars.Add(bar);
                bar.Beers.Add(beer);
                _db.SaveChanges();
                return RedirectToAction("Index", new { barname = barname });
            }
            ViewBag.bar = barname;
            ViewBag.directions = "Something went wrong with the existing beer data. Try again.";
            return View(barbeer);
        }

        //
        // GET: /BarBeers/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BarBeers/Edit/5

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
        // GET: /BarBeers/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BarBeers/Delete/5

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
