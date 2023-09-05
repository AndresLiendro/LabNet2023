using labNetPractica4.LINQ.LOGIC.Costumer;
using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
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
                CustomersFirstThreeRow customerFirstThreeRow = new CustomersFirstThreeRow();
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

        public static void PrintCustomersFirstThreeRow(IEnumerable<CustomersFirstThreeRowDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageCustomerFirstThreeRowDto(item);

            }
        }
    }
}
