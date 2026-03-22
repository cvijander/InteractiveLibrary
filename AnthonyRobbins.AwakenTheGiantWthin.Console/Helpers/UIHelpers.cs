using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers
{
    public static class UIHelpers
    {
        public static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Molimo pritisnite ENTER i ponovo odaberite ali samo neku od ponudjenih opcija.");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void ExitProgram()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hvala sto ste koristili ovaj program. Nadamo se da vam je pomogao da probudite diva u sebi!");
            Console.WriteLine("Pritisnite ENTER za izlaz.");
            Console.ResetColor();
            Console.ReadLine();

            Environment.Exit(0);
        }


        public static void GoToNextPage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pritisnite ENTER za sledecu stranu...");
            Console.ResetColor();
        }
    }
}
