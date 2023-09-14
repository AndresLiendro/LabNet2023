using labNetPracica7.API.Models;
using labNetPractica3.EF.Logic.Order;
using System.Web.Http;
using System.Web.Mvc;

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

        public IHttpActionResult GetById(int id)
        {
            try
            {
                var order = oServicio.GetById(id);
                oDto.Id = order.OrderID;
                oDto.Ship = order.ShipName;
                oDto.City = order.ShipCity; 
                oDto.Region = order.ShipRegion;

                return Ok(oDto);
            }
            catch (System.Exception)
            {
                return BadRequest($"No existe empleado con ID: {id}");
            }
        }

        public IHttpActionResult Post([FromBody] OrdersView oView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    oDto.Ship = oView.ship;
                    oDto.City = oView.city;
                    oDto.Region = oView.region;

                    return Ok("Se creo correctamente la orden");
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

        public IHttpActionResult Put([FromBody] OrdersView oView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updateOrder = new OrderDto
                    {
                        Id = oView.Id,
                        Ship = oView.ship,
                        City = oView.city,
                        Region = oView.region,
                    };  

                    oServicio.Update(updateOrder);
                    return Ok("El empleado se modifico correctamente");
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
                oServicio.Delete(id);
                return Ok("Orden eliminada correctamente");
            }
            catch (System.Exception)
            {

                return BadRequest("Ocurrio un error al intentar elimnar la orden");
            }
        }
    }
}