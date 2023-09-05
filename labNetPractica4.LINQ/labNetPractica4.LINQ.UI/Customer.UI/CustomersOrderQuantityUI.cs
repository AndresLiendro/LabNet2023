using labNetPractica4.LINQ.LOGIC.Customers;
using labNetPractica4.LINQ.LOGIC.Customers.Dtos;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersOrderQuantityUI
    {
        public static void GetCustomersOrderQuantity()
        {
            try
            {
                AppClean.ClearConsole();
                CustomerOrderQuantity customerOrdersQ = new CustomerOrderQuantity();
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

        public static void PrintCustomersOrdersQuantity(IEnumerable<CustomerOrderQuantityDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageCustomerOrderQuantity(item);
            }
        }
    }
}
