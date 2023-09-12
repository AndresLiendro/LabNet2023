using labNetPractica3.EF.Entities;
using labNetPractica3.EF.Logic.Customer;
using labNetPractica3.EF.Logic.Order;
using labNetPractica6.MVC.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labNetPractica6.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerServicio customerServicio = new CustomerServicio();
        private CustomersView customersView = new CustomersView();
        // GET: Customers
        public ActionResult Index()
        {
            var customers = customerServicio.GetAll();
            var customerV = customers.Select(c => new CustomersView
            {
                Id = c.Id,
                companyName = c.CompanyName,
                contactName = c.ContactName,
                contactTitle = c.ContactTitle,
            }).ToList();

            return View(customerV);
        }

        public ActionResult Insert()
        {
            return View("Insert", new CustomersView());
        }

        public ActionResult Update(int id)
        {
            var customerObtenido = customerServicio.GetById(id);
            customersView.Id = customerObtenido.CustomerID;
            customersView.companyName = customerObtenido.CompanyName;
            customersView.contactName = customerObtenido.ContactName;
            customersView.contactTitle = customerObtenido.ContactTitle;

            return View("Update", customersView);
        }

        [HttpPost]
        public ActionResult Insert(CustomersView model)
        {
            if (ModelState.IsValid)
            {
                var nuevoCustomer = new CustomerDto
                {
                    CompanyName = model.companyName,
                    ContactName = model.contactName,
                    ContactTitle = model.contactTitle,
                };

                customerServicio.Insert(nuevoCustomer);
                return RedirectToAction("Index");
            }

            return View("Insert");
        }

        [HttpPost]
        public ActionResult Update(CustomersView model)
        {
            if (ModelState.IsValid)
            {
                var customerMod = new CustomerDto
                {
                    Id = model.Id,
                    CompanyName = model.companyName,
                    ContactName = model.contactName,
                    ContactTitle = model.contactTitle,
                };

                customerServicio.Update(customerMod);
                return RedirectToAction("Index");
            }

            return View("Update");
        }
            

        public ActionResult Delete(int id)
        {
            try
            {
                customerServicio.Delete(id);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException)
            {

                return RedirectToAction("SinPermisos", "Error");
            }
        }
    }
}