using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BeerBarsController : Controller
    {
        //
        // GET: /BeerBars/

        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index(string beername)
        {
            var beer = _db.Beers.Include("Bars").Single(s => s.Name == beername);
            ViewBag.beer = beername;
            return View(beer.Bars.OrderBy(b=>b.Name).ToList());
        }

        //
        // GET: /BeerBars/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BeerBars/Create

        public ActionResult Create(string beername)
        {
            ViewBag.beer = beername;
            return View();
        }

        //
        // POST: /BeerBars/Create

        [HttpPost]
        public ActionResult Create(string beername, BeerBar beerbar)
        {
            if (ModelState.IsValid)
            {
                var beer = _db.Beers.Include("Bars").Single(s => s.Name == beername);
                var bar = _db.Bars.Include("Beers").Single(s => s.Name == beerbar.Name);
                beer.Bars.Add(bar);
                bar.Beers.Add(beer);
                _db.SaveChanges();
                return RedirectToAction("Index", new { beername = beername });
            }
            ViewBag.directions = "Something went wrong with the existing bar data. Try again.";
            ViewBag.beer = beername;
            return View(beerbar);
        }

        //
        // GET: /BeerBars/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BeerBars/Edit/5

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
        // GET: /BeerBars/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BeerBars/Delete/5

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
