using labNetPractica3.EF.Logic.Customer;
using labNetPractica3.EF.Logic.Order;
using labNetPractica6.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labNetPractica6.MVC.Controllers
{
    public class OrdersController : Controller
    {
        private OrderServicio orderServicio = new OrderServicio();
        private OrdersView ordersView = new OrdersView();
        // GET: Orders
        public ActionResult Index()
        {
            var orders = orderServicio.GetAll();
            var ordersV = orders.Select(o => new OrdersView
            {
                Id = o.Id,
                ship = o.Ship,
                city = o.City,
                region = o.Region,
            }).ToList();

            return View(ordersV);
        }

        public ActionResult InsertUpdate(int? id)
        {
            if (id == null)
            {
                return View("InsertUpdate", new OrdersView());
            }
            else
            {
                var orderObtenido = orderServicio.GetById(id.Value);
                ordersView.Id = orderObtenido.OrderID;
                ordersView.ship = orderObtenido.ShipName;
                ordersView.city = orderObtenido.ShipCity;
                ordersView.region = orderObtenido.ShipRegion;

                return View("InsertUpdate", ordersView);
            }
        }

        [HttpPost]
        public ActionResult InsertUpdate(OrdersView model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    var nuevaOrder = (new OrderDto
                    {
                        Ship = model.ship,
                        City = model.city,
                        Region = model.region,
                    });

                    orderServicio.Insert(nuevaOrder);
                    return RedirectToAction("Index");
                }
                else
                {
                    var modificarOrder = new OrderDto
                    {
                        Id = model.Id,
                        Ship = model.ship,
                        City = model.city,
                        Region = model.region,
                    };

                    orderServicio.Update(modificarOrder);
                    return RedirectToAction("Index");
                }
            }

            return View("InsertUpdate");
        }

        public ActionResult Delete(decimal id)
        {
            try
            {
                orderServicio.Delete(id);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException)
            {

                return RedirectToAction("SinPermisos", "Error");
            }
        }
    }
}