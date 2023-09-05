using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Costumer
{
    public class CustomersFirstThreeRow : ContextDb, IGet<CustomersFirstThreeRowDto>
    {
        public IEnumerable<CustomersFirstThreeRowDto> GetConsulta()
        {
            string regionWA = "WA";
            using (context)
            {
                return context.Customers
                    .Where(c => c.Region == regionWA)
                    .Take(3)
                    .Select(c => new CustomersFirstThreeRowDto
                    {
                        Name = c.ContactName,
                        Region = c.Region
                    }).ToList();
            }
        }
    }
}
