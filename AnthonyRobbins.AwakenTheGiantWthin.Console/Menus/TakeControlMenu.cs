using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class TakeControlMenu
    {
        #region Part two Take Control
        private static void DisplayTakeControl()
        {
            Console.Clear();
            Console.WriteLine("==== DRUGI DEO: PREUZIMANJE KONTROLE - GLAVNI SISTEM OVLADAVANJA ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Elementarni uticaj: vas glavni sistem");
            Console.WriteLine("2. Zivotne vrednosti: licni kompas");
            Console.WriteLine("3. Pravila: evo zasto niste srecni");
            Console.WriteLine("4. Asocijacije: tkanina zivota");
            Console.WriteLine("5. Identitet: kljuc za expanziju");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0 Povratak u glavni meni");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("99. -- Napusti program -- ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Unesite opciju: ");

        }

        public static void ChooseToDisplayTakeControl()
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
                DisplayTakeControl();
                string userInput = Console.ReadLine().Trim();
                displayMenu = HandleDisplayTakeControl(userInput);
            }

        }

        private static bool HandleDisplayTakeControl(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("14 tica");
                    Console.ReadLine();
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("15 tica");
                    Console.ReadLine();
                    return true;

                case "3":
                    Console.Clear();
                    Console.WriteLine("16 tica");
                    Console.ReadLine();
                    return true;

                case "4":
                    Console.Clear();
                    Console.WriteLine("17 tica");
                    Console.ReadLine();
                    return true;

                case "5":
                    Console.Clear();
                    Console.WriteLine("18 tica");
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
