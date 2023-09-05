using labNetPractica4.LINQ.LOGIC.Costumer;
using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersOrderQuantityUI
    {
        public static void GetCustomersOrderQuantity()
        {
            try
            {
                AppClean.ClearConsole();
                CustomersOrdersQuantity customerOrdersQ = new CustomersOrdersQuantity();
                var customerOrdersQList = customerOrdersQ.GetConsulta();
                PrintCustomersOrdersQuantity(customerOrdersQList);
            }
            catch (Exception ex)
            {
                Messages.AppMessages.ExceptionMessage(ex);
            }
            finally
            {
                Tries.TryAgain();
            }
        }

        public static void PrintCustomersOrdersQuantity(IEnumerable<CustomersOrdersQuantityDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageCustomerOrderQuantity(item);
            }
        }
    }
}
