using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegalDB.Models;

namespace LegalDB.Controllers
{
    public class HomeController : Controller
    {
        LegalDBWebEntities db = new LegalDBWebEntities();
        public ActionResult Index()
        {
            return View(db.News.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}