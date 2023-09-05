using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Functionalities
{
    public class Tries
    {
        public static void TryAgain()
        {
            JumpOfLine.Jumps();
            Messages.AppMessages.TryAgainMessage();
            int op = UserInput.OnlyNumbers();

            if (op == 1)
            {
                AppClean.ClearConsole();
                Messages.AppMessages.MessagesMainMenu();
                int opcion = UserInput.OnlyNumbers();
                Menus.MainMenu.AppMainMenu(opcion);
            }
            else
            {
                Messages.AppMessages.EndOfTheProgram();
            }
        }
    }
}
