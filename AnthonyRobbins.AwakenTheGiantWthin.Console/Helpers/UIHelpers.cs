using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers
{
    public static class UIHelpers
    {
        public static void ErrorMessage()
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Molimo pritisnite ENTER i ponovo odaberite ali samo neku od ponudjenih opcija.");
            System.Console.ResetColor();
            System.Console.ReadLine();
        }

        public static void ExitProgram()
        {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Hvala sto ste koristili ovaj program. Nadamo se da vam je pomogao da probudite diva u sebi!");
            System.Console.WriteLine("Pritisnite ENTER za izlaz.");
            System.Console.ResetColor();
            System.Console.ReadLine();

            Environment.Exit(0);
        }


        public static void GoToNextPage()
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Pritisnite ENTER za sledecu stranu...");
            System.Console.ResetColor();
        }
    }
}
