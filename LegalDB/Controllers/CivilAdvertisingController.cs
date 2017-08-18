using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegalDB.Models;

namespace LegalDB.Controllers
{
    public class CivilAdvertisingController : Controller
    {
        LegalDBWebEntities db = new LegalDBWebEntities();
        // GET: CivilAdvertising
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AutoScraper()
        {
            return View(db.Jurisdictions.ToList());
        }

        public ActionResult Edit(int id)
        {
            //Jurisdiction jurisdiction = db.Jurisdictions.FirstOrDefault(x => x.ID == id);
            //jurisdiction.LastRunTime = this.
            //return View(db.Jurisdictions.FirstOrDefault(x => x.ID == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult Details(int id)
        {
            return View(db.Jurisdictions.FirstOrDefault(x => x.ID == id));
        }

        public PartialViewResult Edit1(int id)
        {
            Jurisdiction jurisdiction = db.Jurisdictions.FirstOrDefault(x => x.ID == id);
            return PartialView("Edit1", db.Jurisdictions.FirstOrDefault(x => x.ID == id));
        }
    }
}