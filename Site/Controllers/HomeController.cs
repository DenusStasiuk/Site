using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private Models.ShopDBEntities db = new Models.ShopDBEntities();
        public ActionResult Index()
        {
            var Items = db.Items;
            return View(Items);
        }

        // GET: Home
        public ActionResult Asus1()
        {
            var Item = db.Items.Where(i=>i.Title.Contains("15"));
            return View(Item);
        }

        // GET: Home
        public ActionResult Asus2()
        {
            var Item = db.Items.Where(i => i.Title.Contains("17"));
            return View(Item);
        }

        // GET: Home
        public ActionResult Asus3()
        {
            var Item = db.Items.Where(i => i.Title.Contains("13"));
            return View(Item);
        }

      
    }
}