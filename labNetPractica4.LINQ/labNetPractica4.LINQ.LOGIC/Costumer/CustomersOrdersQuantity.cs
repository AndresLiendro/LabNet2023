using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Costumer
{
    public class CustomersOrdersQuantity : ContextDb, IGet<CustomersOrdersQuantityDto>
    {
        public IEnumerable<CustomersOrdersQuantityDto> GetConsulta()
        {
            using (context)
            {
                var query = from c in context.Customers
                            join o in context.Orders
                            on c.CustomerID equals o.CustomerID
                            group o by c.CompanyName into result
                            select new CustomersOrdersQuantityDto
                            {
                                CustomerName = result.Key,
                                CustomerOrder = result.Count()
                            };

                return query.ToList();
            }
        }
    }
}
