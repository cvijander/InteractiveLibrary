using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class TechniquesMenu
    {
        #region Part Five Techniques

        private static void DisplayTechiques()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== TEHNIKE I PRAKTICNI KORACI ====");
            System.Console.WriteLine();
            System.Console.WriteLine("1. Kako da ostvarite trajnu promenu (3 koraka)");
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

        public static void ChooseToDisplayTechiques()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayTechiques();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplayTechiques(userInput);

            }
        }

        private static bool HandleDisplayTechiques(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    System.Console.WriteLine("1 nica");
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
