using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Lessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class QuotesMenu
    {
        private static void DisplayDefinitionsAndQuotes()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== PETI DEO: DEFINICIJE I CITATI ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Definicije i citati");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("0. Povratak u glavni meni");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("99. -- Napusti program -- ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Unesite opciju: ");
        }

        public static void ChooseToDisplayDefinitionAndQuotes()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayDefinitionsAndQuotes();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplayDefinitionsAndQuotes(userInput);
            }
        }

        private static bool HandleDisplayDefinitionsAndQuotes(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    PartFiveLessions.Quotes();
                    System.Console.ReadLine();
                    return true;


                case "0":
                    return false;

                case "99":
                    UIHelpers.ExitProgram();
                    return false;

                default:
                    UIHelpers.ErrorMessage();
                    return true;
            }

        }
    }
}
