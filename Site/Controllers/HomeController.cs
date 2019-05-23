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

        //GET: Home
        public ActionResult Asus15()
        {
            var Item = db.Items.Include("Asus15");
            return View(Item);
        }
    }
}