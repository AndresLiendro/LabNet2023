using labNetPractica3.EF.Logic.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labNetPractica6.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerServicio customerServicio = new CustomerServicio();
        // GET: Customers
        public ActionResult Index()
        {
            var customers = customerServicio.GetAll();

            return View(customers);
        }
    }
}