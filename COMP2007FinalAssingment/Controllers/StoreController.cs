using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007FinalAssingment.Models;

namespace COMP2007FinalAssingment.Controllers
{
    public class StoreController : Controller
    {
        private AtlasStoreContext db = new AtlasStoreContext();

        // GET: Store
        public ActionResult Index(string filter = "")
        {
            if (!String.IsNullOrEmpty(filter))
            {
                ViewBag.Products = db.Products.Where(s => s.Brand.Title.Contains(filter)
                                       || s.Ingredient.Title.Contains(filter)
                                       || s.Goal.Title.Contains(filter)
                                       || s.Title.Contains(filter));
            }
            else
            {
                ViewBag.Products = db.Products;
            }
           
            ViewBag.Brands = db.Brands;
            ViewBag.Goals = db.Goals;
            ViewBag.Ingredients = db.Ingredients;
            
            return View();
        }
    }
}