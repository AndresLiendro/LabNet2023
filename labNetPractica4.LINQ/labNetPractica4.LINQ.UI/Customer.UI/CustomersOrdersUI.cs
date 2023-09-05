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
    public class CustomersOrdersUI
    {
		public static void GetCustomersOrders()
		{
			try
			{
				AppClean.ClearConsole();
				CustomerOrders customerOrders = new CustomerOrders();
				var customerOrdersList = customerOrders.GetConsulta();
				PrintCustomersOrders(customerOrdersList);
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

		public static void PrintCustomersOrders(IEnumerable<CustomerOrdersDto> query)
		{
			foreach (var item in query)
			{
				Messages.AppMessages.MessageeCustomerOrders(item);
			}
		}
	}
}
