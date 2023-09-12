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

        public ActionResult InsertUpdate(int? id)
        {
            if (id == null)
            {
                return View("InsertUpdate", new CustomersView());  
            }
            else
            {
                var customerObtenido = customerServicio.GetById(id.Value);
                customersView.Id = customerObtenido.CustomerID;
                customersView.companyName = customerObtenido.CompanyName;
                customersView.contactName = customerObtenido.ContactName;
                customersView.contactTitle = customerObtenido.ContactTitle;

                return View("InsertUpdate", customersView);

            }
        }

        [HttpPost]
        public ActionResult InsertUpdate(CustomersView model)
        {
            if (ModelState.IsValid)
            {
                if (int.TryParse(model.Id, out int idValue) && idValue == 0)
                {
                    var nuevoCustomer = (new CustomerDto
                    {
                        CompanyName = model.companyName,
                        ContactName = model.contactName,
                        ContactTitle = model.contactTitle,
                    });

                    customerServicio.Insert(nuevoCustomer);
                    return RedirectToAction("Index");
                }
                else {
                    var modificarCustomer = new CustomerDto
                    {
                        Id = model.Id,
                        CompanyName = model.companyName,
                        ContactName = model.contactName,
                        ContactTitle = model.contactTitle,
                    };

                    customerServicio.Update(modificarCustomer);
                    return RedirectToAction("Index");
                }
            }

            return View("InsertUpdate");
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
}