using labNetPractica4.LINQ.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product
{
    public class ProductWithoutStock : ContextDb, IGet<Products>
    {
        public IEnumerable<Products> GetConsulta()
        {
            using (context)
            {
                var query = from p in context.Products
                            where p.UnitsInStock == 0
                            select p;

                return query.ToList();
            }
        }
    }
}
