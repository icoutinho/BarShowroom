using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BeersController : Controller
    {
        //
        // GET: /Beers/

        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index()
        {
            //LoadBarCombo();
            //LoadBreweryCombo();

            var beersAll = _db.Beers.Include("Brewery").OrderBy(b=>b.Name).ToList();
            ViewBag.bar = "all bars";
            return View(beersAll);
            
        }

        //private void LoadBarCombo()
        //{
        //    List<SelectListItem> barList = new List<SelectListItem>();
        //    var bars = _db.Bars.ToList();
        //    barList.Add(new SelectListItem { Text = "", Value = "" });
        //    foreach (Bar b in bars)
        //    {
        //        barList.Add(new SelectListItem { Text = b.Name, Value = b.Name });
        //    }
        //    ViewBag.bars = barList;
        //}

        //private void LoadBreweryCombo()
        //{
        //    List<SelectListItem> breweryList = new List<SelectListItem>();
        //    var breweries = _db.Breweries.ToList();
        //    breweryList.Add(new SelectListItem { Text = "", Value = "" });
        //    foreach (Brewery b in breweries)
        //    {
        //        breweryList.Add(new SelectListItem { Text = b.Name, Value = b.Name });
        //    }
        //    ViewBag.breweries = breweryList;
            
        //}

        //
        // GET: /Beers/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Beers/Create

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.directions = "Fill in the fields for a new beer.";
            return View();
        }

        //
        // POST: /Beers/Create

        [HttpPost]
        public ActionResult Create(Beer beer)
        {
            if (ModelState.IsValid)
            {
                _db.Beers.Add(beer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.directions = "Something went wrong with the new beer data. Try again.";
            return View(beer);
        }

        //
        // GET: /Beers/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Beers/Edit/5

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
        // GET: /Beers/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Beers/Delete/5

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
