using labNetPractica4.LINQ.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product.Message
{
    public class ProductMessage
    {
        public static void ExistProductMessage(Products products)
        {
            Console.WriteLine($"Nombre: {products.ProductName}");
        }
        public static void FirstProductMessage(Products p)
        {
            Console.WriteLine($"Producto: {p.ProductName} - Precio: {p.UnitPrice} - " +
                $"Stock: {p.UnitsInStock}");
        }
        public static void NoExistProductMessage()
        {
            Console.WriteLine("El producto no existe");
        }
    }
}
