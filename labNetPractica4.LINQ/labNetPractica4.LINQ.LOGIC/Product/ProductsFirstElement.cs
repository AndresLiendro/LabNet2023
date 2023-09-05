using labNetPractica4.LINQ.LOGIC.Product.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product
{
    public class ProductsFirstElement : ContextDb
    {
        public bool GetConsult()
        {
            using (context)
            {
                var query = context.Products
                    .FirstOrDefault(p => p.ProductID == 789);

                if (query != null)
                {
                    ProductMessage.ExistProductMessage(query);
                    return true;
                }
                else
                {
                    ProductMessage.NoExistProductMessage();
                    return false;
                }
            }
        }
    }
}
