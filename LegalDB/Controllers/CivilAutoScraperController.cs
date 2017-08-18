using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LegalDB.Models;

namespace LegalDB.Controllers
{
    public class CivilAutoScraperController : Controller
    {
        private LegalDBWebEntities db = new LegalDBWebEntities();

        // GET: CivilAutoScraper
        public ActionResult Index()
        {
            return View(db.Jurisdictions.ToList());
        }

        // GET: CivilAutoScraper/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jurisdiction jurisdiction = db.Jurisdictions.Find(id);
            if (jurisdiction == null)
            {
                return HttpNotFound();
            }
            return View(jurisdiction);
        }

        // GET: CivilAutoScraper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CivilAutoScraper/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,WebAddr,Abbr,Active,IsCounty,CountyID,PrayerExempt,ChkRange,LastRecNo,LastRunTime,LastRunStatus")] Jurisdiction jurisdiction)
        {
            if (ModelState.IsValid)
            {
                db.Jurisdictions.Add(jurisdiction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jurisdiction);
        }

        // GET: CivilAutoScraper/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jurisdiction jurisdiction = db.Jurisdictions.Find(id);
            if (jurisdiction == null)
            {
                return HttpNotFound();
            }
            return View(jurisdiction);
        }

        // POST: CivilAutoScraper/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,WebAddr,Abbr,Active,IsCounty,CountyID,PrayerExempt,ChkRange,LastRecNo,LastRunTime,LastRunStatus")] Jurisdiction jurisdiction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jurisdiction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jurisdiction);
        }

        // GET: CivilAutoScraper/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jurisdiction jurisdiction = db.Jurisdictions.Find(id);
            if (jurisdiction == null)
            {
                return HttpNotFound();
            }
            return View(jurisdiction);
        }

        // POST: CivilAutoScraper/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jurisdiction jurisdiction = db.Jurisdictions.Find(id);
            db.Jurisdictions.Remove(jurisdiction);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
