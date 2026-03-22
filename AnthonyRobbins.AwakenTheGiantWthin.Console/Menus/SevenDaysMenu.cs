using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class SevenDaysMenu
    {
        #region Part Three Seven days to shape your life 
        private static void DisplaySevenDaysToShapeYourLife()
        {
            Console.Clear();
            Console.WriteLine("==== TRECI DEO: SEDAM DANA ZA OBLIKOVANJE VASEG ZIVOTA ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Emocioonalna sudbina: jedini istinski uspeh");
            Console.WriteLine("2. Telesna sudbina: tamnica bola ili plata zadovoljstva");
            Console.WriteLine("3. Sudbina veza: mesto za deljenje i ljubav");
            Console.WriteLine("4. Finansijska sudbina: mali koraci do malog ili velikog bogatstva");
            Console.WriteLine("5. Budite besprekorni: vas kodeks ponasanja");
            Console.WriteLine("6. Ovladajte svojim vremenom i svojom sudbinom");
            Console.WriteLine("7. Odmarajte se i zabavljajte: cak je i bog uzeo slobodan dan");
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

        public static void ChooseToDisplaySevenDaysToShapeYourLife()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplaySevenDaysToShapeYourLife();
                string userInput = Console.ReadLine().Trim();
                displayMenu = HandleDisplaySevenDaysToShapeYourLife(userInput);
            }
        }

        private static bool HandleDisplaySevenDaysToShapeYourLife(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Ovde smo");
                    Console.ReadLine();
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("20 tica");
                    Console.ReadLine();
                    return true;

                case "3":
                    Console.Clear();
                    Console.WriteLine("21 tica");
                    Console.ReadLine();
                    return true;

                case "4":
                    Console.Clear();
                    Console.WriteLine("22 tica");
                    Console.ReadLine();
                    return true;

                case "5":
                    Console.Clear();
                    Console.WriteLine("23 tica");
                    Console.ReadLine();
                    return true;

                case "6":
                    Console.Clear();
                    Console.WriteLine("24 tica");
                    Console.ReadLine();
                    return true;

                case "7":
                    Console.Clear();
                    Console.WriteLine("25 tica");
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
    