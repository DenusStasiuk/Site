using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order
        private Models.ShopDBEntities db = new Models.ShopDBEntities();
        public ActionResult AceptOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(String name, String tel, String type)
        {
            Order order = new Order();
            order.UserName = name;
            order.UserTel = tel;
            if (type.Equals("Asus VivoBook 15"))
            {
                order.ItemID = 1;
            }
            else if (type.Equals("Asus VivoBook 17"))
            {
                order.ItemID = 2;
            }
            else if (type.Equals("Asus VivoBook 13"))
            {
                order.ItemID = 3;
            }
            else { order.ItemID = 0; }
            db.Orders.Add(order);
            db.SaveChanges();


            return Redirect("/Order/AceptOrder");
        }
    }

}