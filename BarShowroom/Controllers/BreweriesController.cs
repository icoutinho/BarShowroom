using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BreweriesController : Controller
    {
        //
        // GET: /Breweries/
        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index()
        {
            return View(_db.Breweries.OrderBy(b=>b.Name).ToList());
        }

        //C:\_pgms\BarShowroom\BarShowroom\Models\
        // GET: /Breweries/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Breweries/Create

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.directions = "Fill in the fields for a new brewery.";
            return View();
        }

        //
        // POST: /Breweries/Create

        [HttpPost]
        public ActionResult Create(Brewery brewery)
        {
            if (ModelState.IsValid)
            {
                _db.Breweries.Add(brewery);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.directions = "Something went wrong with the new brewery data. Try again.";
            return View(brewery);
        }

        //
        // GET: /Breweries/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Breweries/Edit/5

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
        // GET: /Breweries/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Breweries/Delete/5

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
