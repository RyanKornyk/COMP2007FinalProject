using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007FinalAssingment.Models;

namespace COMP2007FinalAssingment.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {

        private AtlasStoreContext db = new AtlasStoreContext();

        public ActionResult Index()
        {
            ViewBag.Products = db.Products;
            return View();
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