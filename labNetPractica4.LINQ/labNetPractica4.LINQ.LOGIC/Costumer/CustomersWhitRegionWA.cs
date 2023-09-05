using labNetPractica4.LINQ.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Costumer
{
    public class CustomersWhitRegionWA : ContextDb, IGet<Customers>
    {
        public IEnumerable<Customers> GetConsulta()
        {
            using (context)
            {
                string region = "WA";
                var query = from c in context.Customers
                            where c.Region == region
                            select c;

                return query.ToList();
            }
        }
    }
}
