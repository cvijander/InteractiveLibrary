using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class SevenDaysMenu
    {
        #region Part Three Seven days to shape your life 
        private static void DisplaySevenDaysToShapeYourLife()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== TRECI DEO: SEDAM DANA ZA OBLIKOVANJE VASEG ZIVOTA ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Emocioonalna sudbina: jedini istinski uspeh");
            System.Console.WriteLine("2. Telesna sudbina: tamnica bola ili plata zadovoljstva");
            System.Console.WriteLine("3. Sudbina veza: mesto za deljenje i ljubav");
            System.Console.WriteLine("4. Finansijska sudbina: mali koraci do malog ili velikog bogatstva");
            System.Console.WriteLine("5. Budite besprekorni: vas kodeks ponasanja");
            System.Console.WriteLine("6. Ovladajte svojim vremenom i svojom sudbinom");
            System.Console.WriteLine("7. Odmarajte se i zabavljajte: cak je i bog uzeo slobodan dan");
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

        public static void ChooseToDisplaySevenDaysToShapeYourLife()
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                DisplaySevenDaysToShapeYourLife();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplaySevenDaysToShapeYourLife(userInput);
            }
        }

        private static bool HandleDisplaySevenDaysToShapeYourLife(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    System.Console.WriteLine("Ovde smo");
                    System.Console.ReadLine();
                    return true;

                case "2":
                    System.Console.Clear();
                    System.Console.WriteLine("20 tica");
                    System.Console.ReadLine();
                    return true;

                case "3":
                    System.Console.Clear();
                    System.Console.WriteLine("21 tica");
                    System.Console.ReadLine();
                    return true;

                case "4":
                    System.Console.Clear();
                    System.Console.WriteLine("22 tica");
                    System.Console.ReadLine();
                    return true;

                case "5":
                    System.Console.Clear();
                    System.Console.WriteLine("23 tica");
                    System.Console.ReadLine();
                    return true;

                case "6":
                    System.Console.Clear();
                    System.Console.WriteLine("24 tica");
                    System.Console.ReadLine();
                    return true;

                case "7":
                    System.Console.Clear();
                    System.Console.WriteLine("25 tica");
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
    