using BarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarShowroom.Controllers
{
    public class BarsController : Controller
    {
        //
        // GET: /Bars/
        BarShowroomDb _db = new BarShowroomDb();

        public ActionResult Index()
        {
            ViewBag.beer = "all beers";
            return View(_db.Bars.OrderBy(b => b.Name).ToList());
        }

        //
        // GET: /Bars/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Bars/Create

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.directions = "Fill in the fields for a new bar.";
            return View();
        }

        //
        // POST: /Bars/Create

        [HttpPost]
        public ActionResult Create(Bar bar)
        {
            if (ModelState.IsValid)
            {
                _db.Bars.Add(bar);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.directions = "Something went wrong with the new bar data. Try again.";
            return View(bar);
        }

        //
        // GET: /Bars/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Bars/Edit/5

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
        // GET: /Bars/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Bars/Delete/5

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

        //static List<Bar> _bars = new List<Bar>
        //{
        //    new Bar {
        //        Id = 1,
        //        Name = "Boteco 1",
        //        Address = "Rua do Malandro Safado",
        //        Cnpj = "12.343.414/1312-31"
        //    },
        //    new Bar {
        //        Id = 2,
        //        Name = "Boteco 2",
        //        Address = "Rua do Safado Malandro",
        //        Cnpj = "12.343.414/1312-31"
        //    },
        //    new Bar {
        //        Id = 3,
        //        Name = "Boteco 3",
        //        Address = "Rua da Esquina Torta",
        //        Cnpj = "12.343.414/1312-31"
        //    }
        //};
    }
}
