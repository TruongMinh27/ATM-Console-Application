using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI
{
    public class AppScreen
    {
        internal static void Welcome()
        {
            //clear the console screen
            Console.Clear();
            //set tiltle of the console window
            Console.Title = "My ATM App";
            // sets the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;

            //set the welcome message
            Console.WriteLine("\n\n--------  Welcom to my ATM App  --------");
            //prompt the user to insert atm card
            Console.WriteLine("Please insert your ATM card");
            Utility.PressEnterToContinue();
        }

        
    }
}
