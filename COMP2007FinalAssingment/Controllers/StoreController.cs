﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007FinalAssingment.Models;
using PagedList;

namespace COMP2007FinalAssingment.Controllers
{
    public class StoreController : Controller
    {
        private AtlasStoreContext db = new AtlasStoreContext();

        // GET: Store
        public ActionResult Index(string sortOrder, string currentFilter, string filter, int? page, int pageSize = 6)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";


            if (filter != null)
            {
                page = 1;
            }
            else
            {
                filter = currentFilter;
            }

            ViewBag.CurrentFilter = filter;

            var products = from s in db.Products
                           select s;

            if (!String.IsNullOrEmpty(filter))
            {
                products = db.Products.Where(s => s.Brand.Title.Contains(filter)
                                       || s.Ingredient.Title.Contains(filter)
                                       || s.Goal.Title.Contains(filter)
                                       || s.Title.Contains(filter));
               
            }

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(s => s.Title);
                    break;
                case "Price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.Title);
                    break;
            }

            ViewData["itemCount"] = products.Count();
            ViewBag.Brands = db.Brands;
            ViewBag.Goals = db.Goals;
            ViewBag.Ingredients = db.Ingredients;

            
            int pageNumber = (page ?? 1);
            return View(products.ToPagedList(pageNumber, pageSize));
        }
    }
}