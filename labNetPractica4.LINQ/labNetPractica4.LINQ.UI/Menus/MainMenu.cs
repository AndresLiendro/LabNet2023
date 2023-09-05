﻿using labNetPractica4.LINQ.UI.Customer.UI;
using labNetPractica4.LINQ.UI.Product.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Menus
{
    public class MainMenu
    {
        public static void AppMainMenu(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    CustomersUI.GetCustomers();
                    break;
                case 2:
                    ProductsWithoutStockUI.ObtenerProductosSinStock();
                    break;
                case 3:
                    ProductWithStockUI.ObtenerProductosConStock();
                    break;
                case 4:
                    CustomersWithWARegionUI.GetCustomersWithWARegion();
                    break;
                case 5:
                    ProductsFirstElementUI.ObtenerProductPrimerElemento();
                    break;
                case 6:
                    CustomersMayMinUI.GetCustomersMayMen();
                    break;
                case 7:
                    CustomersOrdersUI.GetCustomersOrders();
                    break;
                case 8:
                    CustomersFirstThreeRowUI.GetCustomersFirstThreeRow();
                    break;
                case 9:
                    ProductsOrderByNameUI.ObtenerProductOrderByName();
                    break;
                case 10:
                    ProductSinStockMayorMenorUI.ObtenerProductSinStockMayorMenor();
                    break;
                case 11:
                    ProductCategoriesUI.ObtenerProductCategories();
                    break;
                case 12:
                    ProductPrimeroUI.ObtenerProductPrimero();
                    break;
                case 13:
                    CustomerCantidadOrdersUI.ObtenerCustomerCantidadOrders();
                    break;
                default:
                    Mensajes.MensajeOpcionNoValida();
                    Intentos.VolverAIntentarlo();
                    break;
            }
        }
    }
}
