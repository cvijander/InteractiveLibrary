using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Lessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class PeopleAndExamplesMenu
    {
        #region Part Six People and Examples 
        private static void DisplayPeopleAndExamples()
        {
            Console.Clear();
            Console.WriteLine("==== SESTI DEO: LJUDI I PRIMERI  ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Ljudi i primeri ");
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

        public static void ChooseToDisplayPeopleAndExamples()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayPeopleAndExamples();
                string userInput = Console.ReadLine().Trim();
                displayMenu = HandleDisplayPeopleAndExamples(userInput);
            }
        }

        private static bool HandleDisplayPeopleAndExamples(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    PartOneLessions.People();
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

        #endregion
    }
}
