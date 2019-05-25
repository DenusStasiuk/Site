using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private Models.ShopDBEntities db = new Models.ShopDBEntities();
        public ActionResult AdminPage()
        {
            var Items = db.Orders;
            return View(Items);
        }
        [HttpPost]
        public ActionResult AddItem(String title, String type, String description, String preview, int number, int price)
        {
            Item i = new Item();
            i.Title = title;
            i.Type = type;
            i.Description = description;
            i.Preview = preview;
            i.Numbers = number;
            i.Price = price;
            db.Items.Add(i);
            db.SaveChanges();
            return Redirect("/Admin/AdminPage");
        }
    }
}