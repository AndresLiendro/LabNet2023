using labNetPractica3.EF.Data;
using labNetPractica3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic.Order
{
    public class OrderServicio : BasicLogic, ILogic<OrderDto>
    {
        public IEnumerable<OrderDto> GetAll()
        {
            using (context)
            {
                var orders = context.Orders.Select(x => new OrderDto
                {
                    Id = x.OrderID,
                    Ship = x.ShipName,
                    City = x.ShipCity,
                    Region = x.ShipRegion,
                }).ToList();

                return orders;
            }
        }

        public long Insert(OrderDto dto)
        {
            using (context) 
            {
                var NewOrder = new Orders()
                {
                    ShipName = dto.Ship,
                    ShipCity = dto.City,
                    ShipRegion = dto.Region,
                };

                context.Orders.Add(NewOrder);
                context.SaveChanges();

                return NewOrder.OrderID;
            }
        }

        public void Update(OrderDto dto)
        {
            using (context)
            {
                //var UpdateOrder = context.Orders.FirstOrDefault(x => x.OrderID == dto.Id);

                //if (UpdateOrder == null)
                //    throw new Exception("La Orden no existe");

                //UpdateOrder.ShipName = dto.Ship;
                //UpdateOrder.ShipCity = dto.City;
                //UpdateOrder.ShipRegion = dto.Region;

                //context.SaveChanges();

                var UpdateOrder = context.Orders.FirstOrDefault(o => o.OrderID == dto.Id);

                if (UpdateOrder != null)
                {
                    UpdateOrder.ShipName = dto.Ship;
                    UpdateOrder.ShipCity = dto.City;
                    UpdateOrder.ShipRegion = dto.Region;

                    context.SaveChanges();
                }
            }
        }
        public void Delete(long ID)
        {
            using (context)
            {
                //var DeleteOrder = context.Orders.FirstOrDefault(x => x.OrderID == ID);

                //context.Orders.Remove(DeleteOrder);

                //context.SaveChanges();

                var DeleteOrder = context.Orders.FirstOrDefault(o => o.OrderID == ID);

                if (DeleteOrder != null)
                {
                    context.Orders.Remove(DeleteOrder);
                    context.SaveChanges();
                }
            }
        }
    }
}
