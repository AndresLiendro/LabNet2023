using labNetPractica4.LINQ.UI.Customer.UI;
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
                default:
                    break;
            }
        }
    }
}
