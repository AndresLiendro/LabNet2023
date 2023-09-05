using labNetPractica4.LINQ.LOGIC.Costumer;
using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersOrdersUI
    {
		public static void GetCustomersOrders()
		{
			try
			{
				AppClean.ClearConsole();
				CustomersOrders customerOrders = new CustomersOrders();
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

		public static void PrintCustomersOrders(IEnumerable<CustomersOrdersDto> query)
		{
			foreach (var item in query)
			{
				Messages.AppMessages.MessageeCustomerOrders(item);
			}
		}
	}
}
