using labNetPractica3.EF.Logic.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labNetPractica6.MVC.Controllers
{
    public class OrdersController : Controller
    {
        private OrderServicio orderServicio = new OrderServicio();
        // GET: Orders
        public ActionResult Index()
        {
            var orders = orderServicio.GetAll();
            return View(orders);
        }
    }
}