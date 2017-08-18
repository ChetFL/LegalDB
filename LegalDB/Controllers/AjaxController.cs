using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegalDB.Models;

namespace LegalDB.Controllers
{
    public class AjaxController : Controller
    {
        LegalDBWebEntities db = new LegalDBWebEntities();
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult First()
        {
            return PartialView("_Jurisdiction", db.Jurisdictions.Where(x=>x.ID==1).First());
        }

        public PartialViewResult Last()
        {
            return PartialView("_Jurisdiction", db.Jurisdictions.Where(x => x.ID == 2).First());
        }
    }
}