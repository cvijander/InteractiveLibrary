using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class DestinyLessionMenu
    {


        #region Part Four Destiny lession
        private static void DisplayDestinyLesson()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== CETVRTI DEO: POUKA O SUDBINI ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Konacni izazov: sta pojedinac moze da uradi");
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

        public static void ChooseToDisplayDestinyLession()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayDestinyLesson();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplayDestinyLession(userInput);

            }
        }

        private static bool HandleDisplayDestinyLession(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    System.Console.WriteLine("26 tica");
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
