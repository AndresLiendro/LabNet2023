using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Costumer
{
    public class CustomersOrders : ContextDb, IGet<CustomersOrdersDto>
    {
        public IEnumerable<CustomersOrdersDto> GetConsulta()
        {
            DateTime orderDate = new DateTime(1997, 1, 1);
            using (context)
            {
                var query = from c in context.Customers
                            where c.Region == "WA"
                            join o in context.Orders
                            on c.CustomerID equals o.CustomerID
                            where o.OrderDate > orderDate
                            orderby o.OrderDate
                            select new CustomersOrdersDto
                            {
                                CustomerName = c.ContactName,
                                Region = c.Region,
                                OrderDate = (DateTime)o.OrderDate,
                            };

                return query.ToList();
            }
        }
    }
}
