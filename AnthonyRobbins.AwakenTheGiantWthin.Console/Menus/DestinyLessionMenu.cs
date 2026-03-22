using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class DestinyLessionMenu
    {


        #region Part Four Destiny lession
        private static void DisplayDestinyLesson()
        {
            Console.Clear();
            Console.WriteLine("==== CETVRTI DEO: POUKA O SUDBINI ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Konacni izazov: sta pojedinac moze da uradi");
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

        public static void ChooseToDisplayDestinyLession()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayDestinyLesson();
                string userInput = Console.ReadLine().Trim();
                displayMenu = HandleDisplayDestinyLession(userInput);

            }
        }

        private static bool HandleDisplayDestinyLession(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("26 tica");
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
