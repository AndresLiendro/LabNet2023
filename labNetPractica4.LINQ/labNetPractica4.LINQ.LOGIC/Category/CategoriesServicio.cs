using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Categories
{
    public class CategoriesServicio : ContextDb, IGet<CategoriesDto>
    {
        public IEnumerable<CategoriesDto> GetConsulta()
        {
            using (context)
            {
                var query = (from c in context.Categories
                             join p in context.Products
                             on c.CategoryID equals p.CategoryID
                             select new CategoriesDto
                             {
                                 Categories = c.CategoryName
                             }).Distinct();
                return query.ToList();
            }
        }
    }
}
