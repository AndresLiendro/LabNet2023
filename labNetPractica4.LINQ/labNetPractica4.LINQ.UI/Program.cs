using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.AppMessages.MessagesMainMenu();
            Menus.MainMenu.AppMainMenu(UserInput.OnlyNumbers());
        }
    }
}
