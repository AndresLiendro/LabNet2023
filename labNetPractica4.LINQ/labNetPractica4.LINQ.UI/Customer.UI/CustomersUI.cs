using labNetPractica4.LINQ.LOGIC.Costumer;
using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersUI
    {
        public static void GetCustomers()
        {
            try
            {
                AppClean.ClearConsole();
                CustomersServicio customerLogic = new CustomersServicio();
                var customersList = customerLogic.GetConsulta();
                PrintCustomers(customersList);
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

        public static void PrintCustomers(IEnumerable<CustomersDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageCustomer(item);
            }
        }
    }
}

