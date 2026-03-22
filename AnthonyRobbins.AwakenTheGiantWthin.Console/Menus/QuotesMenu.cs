using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Lessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class QuotesMenu
    {
        private static void DisplayDefinitionsAndQuotes()
        {
            Console.Clear();
            Console.WriteLine("==== PETI DEO: DEFINICIJE I CITATI ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Definicije i citati");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0. Povratak u glavni meni");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("99. -- Napusti program -- ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Unesite opciju: ");
        }

        public static void ChooseToDisplayDefinitionAndQuotes()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayDefinitionsAndQuotes();
                string userInput = Console.ReadLine().Trim();
                displayMenu = HandleDisplayDefinitionsAndQuotes(userInput);
            }
        }

        private static bool HandleDisplayDefinitionsAndQuotes(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    PartFiveLessions.Quotes();
                    Console.ReadLine();
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
