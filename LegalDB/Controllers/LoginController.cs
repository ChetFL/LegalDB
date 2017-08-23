using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security;

namespace LegalDB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.Employee objUser)
        {
            if (ModelState.IsValid)
            {
                using (Models.LegalDBWebEntities db = new Models.LegalDBWebEntities())
                {
                    var obj = db.Employees.Where(a => a.UserName.Equals(objUser.UserName) && a.UserPassword.Equals(objUser.UserPassword)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.EmployeeID.ToString();
                        Session["UserName"] = obj.UserName.ToString();
                        Session["FullName"] = obj.FirstName + " " + obj.LastName;
                        Session["AuthenticatedUser"] = true;
                        return RedirectToAction("Index","Home");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}