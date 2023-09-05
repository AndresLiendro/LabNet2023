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
    public class CustomersFirstThreeRowUI
    {
        public static void CustomersFirstThreeRow()
        {
            try
            {
                AppClean.ClearConsole();
                CustomerFirstThreeRow customerFirstThreeRow = new CustomerFirstThreeRow();
                var customerThreeRowList = customerFirstThreeRow.GetConsulta();
                PrintCustomersFirstThreeRow(customerThreeRowList);
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

        public static void PrintCustomersFirstThreeRow(IEnumerable<CustomerFirstThreeRowDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageCustomerFirstThreeRowDto(item);

            }
        }
    }
}
