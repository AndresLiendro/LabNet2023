using labNetPractica4.LINQ.LOGIC.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Customers
{
    public class CustomerOrderQuantity : ContextDb, IGet<CustomerOrderQuantityDto>
    {
        public IEnumerable<CustomerOrderQuantityDto> GetConsulta()
        {
            using (context)
            {
                var query = from c in context.Customers
                            join o in context.Orders
                            on c.CustomerID equals o.CustomerID
                            group o by c.CompanyName into result
                            select new CustomerOrderQuantityDto
                            {
                                CustomerName = result.Key,
                                OrderQuantity = result.Count()
                            };

                return query.ToList();
            }
        }
    }    
}
