using labNetPractica4.LINQ.LOGIC.Costumer;
using labNetPractica4.LINQ.LOGIC.Costumer.Dto;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersMayMinUI
    {
		public static void GetCustomersMayMen()
		{
			try
			{
				AppClean.ClearConsole();
				CustomersMayMin customerMayulaMinu = new CustomersMayMin();
				var customerList = customerMayulaMinu.GetConsulta();
				PrintCustomerMayMin(customerList);
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

		public static void PrintCustomerMayMin(IEnumerable<CustomersMayMinDto> query)
		{
			foreach (var item in query)
			{
				Messages.AppMessages.MessageCustomerMayMen(item);
			}
		}
	}
}
