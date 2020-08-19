using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IngredientTracker.Models;
using IngredientTracker.DataContent;

namespace IngredientTracker.Controllers
{
    public class AccountsController : Controller
    {
        DBIngredientTracker db = new DBIngredientTracker();

        // GET: Accounts
        public ActionResult UserType()
        {
            //if(Session["manager"] == null)
            //{
            //    return RedirectToAction("");
            //}
            return View();
        }
        //GET: Manager
        public ActionResult ManagerRegistration()
        {
            return View();
        }
        //GET: ManagerRegistration
        [HttpPost]
        public ActionResult ManagerRegistration(ManagerRegistration mreg)
        {
            if (ModelState.IsValid)
            {
                db.ManagerRegistrations.Add(mreg);
                db.SaveChanges();
                return RedirectToAction("ManagerLogin");
            }
            return RedirectToAction("ManagerLogin");
        }

        public ActionResult ManagerLogin()
        {
            return View();
        }
        //GET: ManagerLogin
        [HttpPost]
        public ActionResult ManagerLogin(ManagerRegistration mlogin)
        {
            var managerlogin = db.ManagerRegistrations.Where(x => x.UserName == mlogin.UserName && x.Password == mlogin.Password).FirstOrDefault();
            if (managerlogin != null)
            {
                Session["manager"] = mlogin.UserName;
                return RedirectToAction("Index", "Ingredients");
            }
            return View();
        }

        public ActionResult ChefRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChefRegistration(ChefRegistration creg)
        {
            if (ModelState.IsValid)
            {
                db.ChefRegistrations.Add(creg);
                db.SaveChanges();
                return RedirectToAction("Index", "Ingredients");
            }
            return RedirectToAction("Index", "Ingredients");
        }

        public ActionResult ChefLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChefLogin(ChefRegistration clogin)
        {
            var cheflogin = db.ChefRegistrations.Where(x => x.UserName == clogin.UserName && x.Password == clogin.Password).FirstOrDefault();
            if (cheflogin != null)
            {
                Session["chef"] = clogin.UserName;
                return RedirectToAction("Index", "Chefs");
            }
            return View();
        }

        public JsonResult IsUNameExits(string UserName)
        {
            UserName.Trim();
            if (!db.ManagerRegistrations.ToList().Any(m => m.UserName.ToLower() == UserName.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsPhoneExits(string Phone)
        {
            Phone.Trim();
            if (!db.ManagerRegistrations.ToList().Any(m => m.Phone.ToLower() == Phone.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsEmailExits(string Email)
        {
            Email.Trim();
            if (!db.ManagerRegistrations.ToList().Any(m => m.Email.ToLower() == Email.ToLower()))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        


    }
}