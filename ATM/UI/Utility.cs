using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI
{
    public static class Utility
    {
        public static string GetUserInput(string promt)
        {
            Console.WriteLine($"Enter {promt}");
            return Console.ReadLine();
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress enter to continue . . .");
            Console.ReadLine();
        }
    }
}
