using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Costumer
{
    public class CustomersMayMin : ContextDb, IGet<CustomersMayMinDto>
    {
        public IEnumerable<CustomersMayMinDto> GetConsulta()
        {
            using (context)
            {
                return context.Customers
                    .Select(c => new CustomersMayMinDto
                    {
                        Mayuscula = c.ContactName.ToUpper(),
                        Minuscula = c.ContactName.ToLower(),
                    }).ToList();
            }
        }
    }
}
