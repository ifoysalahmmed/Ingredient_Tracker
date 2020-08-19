using IngredientTracker.DataContent;
using IngredientTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IngredientTracker.Controllers
{
    public class ChefsController : Controller
    {
        private DBIngredientTracker db = new DBIngredientTracker();

        // GET: Chefs
        public ActionResult Index()
        {
            return View(db.Recipes.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }
    }
}