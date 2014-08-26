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
    public class SubsystemController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        //
        // GET: /Subsystem/

        public ActionResult Index()
        {
            return View(db.Subsystems.ToList());
        }

        //
        // GET: /Subsystem/Details/5

        public ActionResult Details(int id = 0)
        {
            Subsystem subsystem = db.Subsystems.Find(id);
            if (subsystem == null)
            {
                return HttpNotFound();
            }
            return View(subsystem);
        }

        //
        // GET: /Subsystem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Subsystem/Create

        [HttpPost]
        public ActionResult Create(Subsystem subsystem)
        {
            if (ModelState.IsValid)
            {
                db.Subsystems.Add(subsystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subsystem);
        }

        //
        // GET: /Subsystem/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Subsystem subsystem = db.Subsystems.Find(id);
            if (subsystem == null)
            {
                return HttpNotFound();
            }
            return View(subsystem);
        }

        //
        // POST: /Subsystem/Edit/5

        [HttpPost]
        public ActionResult Edit(Subsystem subsystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subsystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subsystem);
        }

        //
        // GET: /Subsystem/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Subsystem subsystem = db.Subsystems.Find(id);
            if (subsystem == null)
            {
                return HttpNotFound();
            }
            return View(subsystem);
        }

        //
        // POST: /Subsystem/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Subsystem subsystem = db.Subsystems.Find(id);
            db.Subsystems.Remove(subsystem);
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