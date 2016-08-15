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
        public ActionResult Index()
        {
            ViewBag.Products = db.Products;
            ViewBag.Brands = db.Brands;
            ViewBag.Goals = db.Goals;
            ViewBag.Ingredients = db.Ingredients;
            
            return View();
        }
    }
}