using labNetPractica4.LINQ.LOGIC.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Customers
{
    public class CustomerFirstThreeRow : ContextDb, IGet<CustomerFirstThreeRowDto>
    {
        public IEnumerable<CustomerFirstThreeRowDto> GetConsulta()
        {
            string WARegion = "WA";
            using (context)
            {
                return context.Customers
                    .Where(r => r.Region == WARegion)
                    .Take(3)
                    .Select(c => new CustomerFirstThreeRowDto
                    {
                        Name = c.ContactName,
                        Region = c.Region
                    }).ToList();
            }
        }
    }
}
