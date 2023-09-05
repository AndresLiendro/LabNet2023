using labNetPractica4.LINQ.LOGIC.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Customers
{
    public class CustomerOrders : ContextDb, IGet<CustomerOrdersDto>
    {
        public IEnumerable<CustomerOrdersDto> GetConsulta()
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
                            select new CustomerOrdersDto
                            {
                                CustomerName = c.ContactName,
                                Region = c.Region,
                                OrderDate = (DateTime)orderDate,
                            };
                return query.ToList();

            }
        }
    }
}
