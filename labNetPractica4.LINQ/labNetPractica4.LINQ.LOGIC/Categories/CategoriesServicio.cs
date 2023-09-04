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
            return null;
        }
    }
}
