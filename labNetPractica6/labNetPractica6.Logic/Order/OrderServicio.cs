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
            var orders = context.Orders.Select(x => new OrderDto
            {
                Id = x.OrderID,
                Ship = x.ShipName,
                City = x.ShipCity,
                Region = x.ShipRegion,
            }).ToList();

            return orders;
        }

        public bool Insert(OrderDto dto)
        {
            try
            {
                var NewOrder = new Orders()
                {
                    ShipName = dto.Ship,
                    ShipCity = dto.City,
                    ShipRegion = dto.Region,
                };

                context.Orders.Add(NewOrder);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(OrderDto dto)
        {
            try
            {
                var UpdateOrder = context.Orders.FirstOrDefault(o => o.OrderID == dto.Id);

                if (UpdateOrder != null)
                {
                    UpdateOrder.ShipName = dto.Ship;
                    UpdateOrder.ShipCity = dto.City;
                    UpdateOrder.ShipRegion = dto.Region;

                    context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(long ID)
        {
            try
            {
                var DeleteOrder = context.Orders.FirstOrDefault(o => o.OrderID == ID);

                if (DeleteOrder != null)
                {
                    context.Orders.Remove(DeleteOrder);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
