using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Customers
{
    public class CustomersServicio : ContextDb, IGet<CustomersDto>
    {
        public IEnumerable<CustomersDto> GetConsulta()
        {
            using (context)
            {
                return context.Customers
                    .Take(1)
                    .Select(c => new CustomersDto
                    {
                        Id = c.CustomerID,
                        Name = c.CompanyName
                    }).ToList();
            }
        }
    }
}
