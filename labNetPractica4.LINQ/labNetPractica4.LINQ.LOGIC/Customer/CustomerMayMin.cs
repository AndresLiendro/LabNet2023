using labNetPractica4.LINQ.LOGIC.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Customers
{
    public class CustomerMayMin : ContextDb, IGet<CustomerMayMinDto>
    {
        public IEnumerable<CustomerMayMinDto> GetConsulta()
        {
            using (context)
            {
                return context.Customers
                    .Select(c => new CustomerMayMinDto
                    {
                        Mayuscula = c.ContactName.ToUpper(),
                        Minuscula = c.ContactName.ToLower()
                    }).ToList();
            }
        }
    }
}
