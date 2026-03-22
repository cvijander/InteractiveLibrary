using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Lessions;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Technics;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class TechniquesMenu
    {
        #region Part Five Techniques

        private static void DisplayTechiques()
        {
            Console.Clear();
            Console.WriteLine("==== TEHNIKE I PRAKTICNI KORACI ====");
            Console.WriteLine();
            Console.WriteLine("1. Kako da ostvarite trajnu promenu (3 koraka)");
            Console.WriteLine("2. Sledeca tehnika");
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

        public static void ChooseToDisplayTechiques()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplayTechiques();
                string userInput = Console.ReadLine().Trim();
                displayMenu = HandleDisplayTechiques(userInput);

            }
        }

        private static bool HandleDisplayTechiques(string input)
        {
            switch (input)
            {
                case "1":
                    BookBase.AllTechnics[0].ShowTechnic();
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("2 jka");
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
