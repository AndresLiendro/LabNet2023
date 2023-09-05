using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product
{
    public class ProductsOrderByName : ContextDb, IGet<ProductsOrderByNameDto>
    {
        public IEnumerable<ProductsOrderByNameDto> GetConsulta()
        {
            using (context)
            {
                return context.Products
                    .Select(p => new ProductsOrderByNameDto
                    {
                        ProductName = p.ProductName
                    }).OrderBy(p => p.ProductName)
                    .ToList();
            }
        }
    }
}
