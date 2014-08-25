using GenTestCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenTestCase.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        GTCEntities db = new GTCEntities();

        public ActionResult Index()
        {
            var testCases = db.TestCases.ToList();

            return View(testCases);
        }


        //GET
        public ActionResult Create()
        {
            ViewBag.SubsystemId = new SelectList(db.Subsystems, "SubsystemId", "Name");
            ViewBag.TestPhaseId = new SelectList(db.TestPhases, "TestPhaseId", "Name");
            ViewBag.EquipmentId = new SelectList(db.Equipments, "EquipmentId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(TestCase tCase)
        {
            if (ModelState.IsValid)
            {
                db.TestCases.Add(tCase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubsystemId = new SelectList(db.Subsystems, "SubsystemId", "Name", tCase.SubsystemId);
            ViewBag.TestPhaseId = new SelectList(db.TestPhases, "TestPhaseId", "Name", tCase.TestPhaseId);
            ViewBag.EquipmentId = new SelectList(db.Equipments, "EquipmentId", "Name", tCase.EquipmentId);

            return View(tCase);
        }


        // GET
        public ActionResult Delete(int id = 0)
        {
            TestCase tCase = db.TestCases.Find(id);
            if (tCase == null)
            {
                return HttpNotFound();
            }
            return View(tCase);
        }

        // GET
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TestCase tCase = db.TestCases.Find(id);
            db.TestCases.Remove(tCase);
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
