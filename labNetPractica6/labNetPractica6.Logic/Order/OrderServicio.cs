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
        public List<OrderDto> GetAll()
        {
            IEnumerable<Orders> orders = context.Orders.AsEnumerable();
            List<OrderDto> result = orders.Select(x => new OrderDto
            {
                Id = x.OrderID,
                Ship = x.ShipName,
                City = x.ShipCity,
                Region = x.ShipRegion,
                CreateDate = DateTime.Now,
            }).ToList();

            return result;
        }

        public bool Insert(OrderDto dto)
        {
            var NewOrder = new Orders()
            {
                ShipName = dto.Ship,
                ShipCity = dto.City,
                ShipRegion = dto.Region,
                OrderDate = dto.CreateDate,
            };

                context.Orders.Add(NewOrder);
                return context.SaveChanges() > 0;
        }

        public bool Update(OrderDto dto)
        {
            bool result = false;
            Orders orderU = context.Orders.FirstOrDefault(o => o.OrderID == (dto.Id));

            if (orderU != null)
            {
                orderU.ShipName = dto.Ship;
                orderU.ShipCity = dto.City;
                orderU.ShipRegion = dto.Region;
                orderU.OrderDate = dto.CreateDate;

                result  = context.SaveChanges() > 0;
            }

            return result;
        }
        public bool Delete(int ID)
        {
            bool result = false;
            Orders orderD = context.Orders.FirstOrDefault(o => o.OrderID.Equals(ID));

            if (orderD != null)
            {
                context.Orders.Remove(orderD);
                result = context.SaveChanges() > 0;
            }

            return result;
        }

        public Orders GetById(int id)
        {
            return context.Orders.FirstOrDefault(e => e.OrderID.Equals(id));
        }
    }
}
