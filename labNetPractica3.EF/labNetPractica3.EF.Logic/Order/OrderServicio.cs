using labNetPractica3.EF.Data;
using labNetPractica3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic.Order
{
    public class OrderServicio : ILogic<OrderDto>
    {
        public IEnumerable<OrderDto> GetAll()
        {
            using (var context = new NorthwindContext())
            {
                return context.Orders.Select(x => new OrderDto
                {
                    Id = x.OrderID,
                    Ship = x.ShipName,
                    City = x.ShipCity,
                    Region = x.ShipRegion,
                }).ToList();
            }
        }

        public long Insert(OrderDto dto)
        {
            using (var context = new NorthwindContext()) 
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
            using (var context = new NorthwindContext())
            {
                var UpdateOrder = context.Orders.FirstOrDefault(x => x.OrderID == dto.Id);

                if (UpdateOrder == null)
                    throw new Exception("La Orden no existe");

                UpdateOrder.ShipName = dto.Ship;
                UpdateOrder.ShipCity = dto.City;
                UpdateOrder.ShipRegion = dto.Region;

                context.SaveChanges();
            }
        }
        public void Delete(decimal ID)
        {
            using (var context = new NorthwindContext())
            {
                var DeleteOrder = context.Orders.FirstOrDefault(x => x.OrderID == ID);

                context.Orders.Remove(DeleteOrder);

                context.SaveChanges();
            }
        }
    }
}
