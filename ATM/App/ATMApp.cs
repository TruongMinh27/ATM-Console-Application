using ATM.UI;

namespace ATM.App
{
    internal class ATMApp
    {
        static void Main(string[] args)
        {
           AppScreen.Welcome();
            string name = Utility.GetUserInput("your name");
            Console.WriteLine($"Your name is {name}");
            Utility.PressEnterToContinue();
        }
    }
}