using labNetPracica7.API.Models;
using labNetPractica3.EF.Entities;
using labNetPractica3.EF.Logic.Order;
using System;
using System.Web.Http;

namespace labNetPracica7.API.Controllers
{
    public class OrdersController : ApiController
    {
        private OrderServicio oServicio = new OrderServicio();
        private OrderDto oDto = new OrderDto();
        private OrdersView oView = new OrdersView();
        // GET: Orders
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(oServicio.GetAll());
            }
            catch (System.Exception)
            {
                return BadRequest("Ocurrio un error al obtener las ordenes");
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                Orders orders = oServicio.GetById(id);
                oView.Id = orders.OrderID;
                oView.Ship = orders.ShipName;
                oView.City = orders.ShipCity;
                oView.Region = orders.ShipRegion;
                oView.CreateDate = (DateTime)orders.OrderDate;

                return Ok(oView);
            }
            catch (System.Exception)
            {
                return BadRequest($"No existe empleado con ID: {id}");
            }
        }

        public IHttpActionResult Post([FromBody] OrdersView orderView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    oDto.Ship = orderView.Ship;
                    oDto.City = orderView.City;
                    oDto.Region = orderView.Region;
                    oDto.CreateDate = DateTime.Now;

                    oServicio.Insert(oDto);

                    // id devuelve 0 por ser Insert, en BD figura con el Id correspondiente
                    return CreatedAtRoute("DefaultApi", new { id = orderView }, orderView);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (System.Exception)
            {
                return BadRequest("Ocurrio un error al crear la orden");
            }
        }

        public IHttpActionResult Put(int id, [FromBody] OrdersView ordersView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Orders order = oServicio.GetById(id);
                    if (order.OrderID == ordersView.Id)
                    {
                        oDto.Id = ordersView.Id;
                        oDto.Ship = ordersView.Ship;
                        oDto.City = ordersView.City;
                        oDto.Region = ordersView.Region;

                        oServicio.Update(oDto);
                    }

                    return Ok(oDto);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (System.Exception)
            {

                return BadRequest("Ocurrio un problema al modificar la orden");
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                Orders orders = oServicio.GetById(id);
                oServicio.Delete(orders.OrderID);
                return Ok("Orden eliminada correctamente");
            }
            catch (System.Exception)
            {

                return BadRequest("Ocurrio un error al intentar elimnar la orden");
            }
        }
    }
}