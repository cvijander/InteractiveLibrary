using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class TakeControlMenu
    {
        #region Part two Take Control
        private static void DisplayTakeControl()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== DRUGI DEO: PREUZIMANJE KONTROLE - GLAVNI SISTEM OVLADAVANJA ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Elementarni uticaj: vas glavni sistem");
            System.Console.WriteLine("2. Zivotne vrednosti: licni kompas");
            System.Console.WriteLine("3. Pravila: evo zasto niste srecni");
            System.Console.WriteLine("4. Asocijacije: tkanina zivota");
            System.Console.WriteLine("5. Identitet: kljuc za expanziju");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("0 Povratak u glavni meni");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("99. -- Napusti program -- ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Unesite opciju: ");

        }

        public static void ChooseToDisplayTakeControl()
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
                DisplayTakeControl();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplayTakeControl(userInput);
            }

        }

        private static bool HandleDisplayTakeControl(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    System.Console.WriteLine("14 tica");
                    System.Console.ReadLine();
                    return true;

                case "2":
                    System.Console.Clear();
                    System.Console.WriteLine("15 tica");
                    System.Console.ReadLine();
                    return true;

                case "3":
                    System.Console.Clear();
                    System.Console.WriteLine("16 tica");
                    System.Console.ReadLine();
                    return true;

                case "4":
                    System.Console.Clear();
                    System.Console.WriteLine("17 tica");
                    System.Console.ReadLine();
                    return true;

                case "5":
                    System.Console.Clear();
                    System.Console.WriteLine("18 tica");
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
