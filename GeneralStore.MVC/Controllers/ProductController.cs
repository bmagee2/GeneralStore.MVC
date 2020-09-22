using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class ProductController : Controller
    {

        // Add the application DB Context (link to the database)
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Product -- list of all products
        public ActionResult Index()
        {
            return View(_db.Products.ToList());     // returns Products table in db as a list 
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}