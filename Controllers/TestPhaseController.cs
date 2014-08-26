using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenTestCase.Models;

namespace GenTestCase.Controllers
{
    public class TestPhaseController : Controller
    {
        private GTCEntities db = new GTCEntities();

        //
        // GET: /TestPhase/

        public ActionResult Index()
        {
            return View(db.TestPhases.ToList());
        }

        //
        // GET: /TestPhase/Details/5

        public ActionResult Details(int id = 0)
        {
            TestPhase testphase = db.TestPhases.Find(id);
            if (testphase == null)
            {
                return HttpNotFound();
            }
            return View(testphase);
        }

        //
        // GET: /TestPhase/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TestPhase/Create

        [HttpPost]
        public ActionResult Create(TestPhase testphase)
        {
            if (ModelState.IsValid)
            {
                db.TestPhases.Add(testphase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testphase);
        }

        //
        // GET: /TestPhase/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TestPhase testphase = db.TestPhases.Find(id);
            if (testphase == null)
            {
                return HttpNotFound();
            }
            return View(testphase);
        }

        //
        // POST: /TestPhase/Edit/5

        [HttpPost]
        public ActionResult Edit(TestPhase testphase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testphase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testphase);
        }

        //
        // GET: /TestPhase/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TestPhase testphase = db.TestPhases.Find(id);
            if (testphase == null)
            {
                return HttpNotFound();
            }
            return View(testphase);
        }

        //
        // POST: /TestPhase/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TestPhase testphase = db.TestPhases.Find(id);
            db.TestPhases.Remove(testphase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}