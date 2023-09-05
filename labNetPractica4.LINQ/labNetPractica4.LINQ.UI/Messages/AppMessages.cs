using labNetPractica4.LINQ.ENTITIES;
using labNetPractica4.LINQ.LOGIC.Categories;
using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using System;

namespace labNetPractica4.LINQ.UI.Messages
{
    public class AppMessages
    {
        public static void MessagesMainMenu()
        {
            Console.WriteLine("----- Menu Principal -----");
            Console.WriteLine();
            Console.WriteLine("1 - Mostrar todos los cliente.");
            Console.WriteLine("2 - Mostrar productos sin Stock.");
            Console.WriteLine("3 - Mostrar productos con Stock y que cuestan mas de 3 por unidad.");
            Console.WriteLine("4 - Mostrar clientes por Region = WA");
            Console.WriteLine("5 - Producto ID = 789");
            Console.WriteLine("6 - Mostrar nombres de clientes en Mayuscula y Miniscula.");
            Console.WriteLine("7 - Mostrar clientes por Region = WA y fecha mayor a 1/1/1997");
            Console.WriteLine("8 - Mostrar clientes por Region = WA, los primeros 3,");
            Console.WriteLine("9 - Mostrar productos ordenados por nombre");
            Console.WriteLine("10 - Mostrar productos ordenados por Stock vacio de Mayor a Menor.");
            Console.WriteLine("11 - Mostrar distintas categorias de los productos");
            Console.WriteLine("12 - Mostrar el primer elemento de una lista de Productos.");
            Console.WriteLine("13 - Mostrar la cantidad de clientes con ordenes asociadas");
        }
        public static void MessageCustomer(CustomersDto cd)
        {
            Console.WriteLine($"Nombre Cliente: {cd.Name}");
        }
        public static void MessageCustomerOrderQuantity(CustomersOrdersQuantityDto cco)
        {
            Console.WriteLine($"Nombre cliente: {cco.CustomerName} - Ordenes: {cco.CustomerOrder}");
        }
        public static void MessageCustomerFirstThreeRowDto(CustomersFirstThreeRowDto cpt)
        {
            Console.WriteLine($"Nombre: {cpt.Name} - Region: {cpt.Region}");
        }

        public static void MessageCustomerWithWARegion(Customers cs)
        {
            Console.WriteLine($"Nombre: {cs.ContactName} - Region: {cs.Region}");
        }

        public static void MessageCustomerMayMen(CustomersMayMinDto cmn)
        {
            Console.WriteLine($"Nombre en Mayuscula: {cmn.Mayuscula} - Nombre en Miniscula: {cmn.Minuscula}");
        }

        public static void MessageeCustomerOrders(CustomersOrdersDto co)
        {
            Console.WriteLine($"Nombre: {co.CustomerName} - Region: {co.Region} - Fecha: {co.OrderDate}");
        }
        public static void MessageProductsWithoutStock(Products pd)
        {
            Console.WriteLine($"Producto: {pd.ProductName} - Sin stock: {pd.UnitsInStock}");
        }

        public static void MessageProductsWithStock(ProductsWithStockDto pd)
        {
            Console.WriteLine($"Producto: {pd.Name} - Stock: {pd.ProductStock} - " +
                $"Unidades que cuestan mas de 3: {pd.UnitPrice}");
        }

        public static void MessageProductsWithoutStockMayMen(ProductsWithoutStockMayMenDto pmn)
        {
            Console.WriteLine($"Nombre productos: {pmn.Name} - Sotck: {pmn.Stock}");
        }

        public static void MessageProductCategorie(CategoriesDto pc)
        {
            Console.WriteLine($"Categorias: {pc.Categories}.");
        }

        public static void MessageProductOrderByName(ProductsOrderByNameDto pon)
        {
            Console.WriteLine($"Nombre producto: {pon.ProductName}");
        }

        public static void ExceptionMessage(Exception ex)
        {
            Console.WriteLine($"Error al intentar Obtener los Customer. \n{ex}");
        }

        public static void OptionNoValidMessage()
        {
            Console.WriteLine("Opcion no valida.");
        }

        public static void TryAgainMessage()
        {
            Console.WriteLine("¿Volver a intentarlo?" +
                "\nPresione 1 para SI" + "\nPresione cualquier NUMERO para salir.");
        }
        public static void EndOfTheProgram()
        {
            Console.WriteLine("Fin del programa.");
            Console.ReadLine();
        }
    }
}
