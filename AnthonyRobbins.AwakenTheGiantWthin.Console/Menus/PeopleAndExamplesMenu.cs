using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Lessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class PeopleAndExamplesMenu
    {
        #region Part Six People and Examples 
        private static void DisplayPeopleAndExamples()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== SESTI DEO: LJUDI I PRIMERI  ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Ljudi i primeri ");
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

        public static void ChooseToDisplayPeopleAndExamples()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayPeopleAndExamples();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplayPeopleAndExamples(userInput);
            }
        }

        private static bool HandleDisplayPeopleAndExamples(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    PartOneLessions.People();
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

        #endregion
    }
}
