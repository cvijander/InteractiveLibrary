using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Lessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class FreeYourPowerMenu
    {
        #region Part One  Free your power menu
        private static void DisplayFreeYourPower()
        {
            Console.Clear();
            Console.WriteLine("==== PRVI DEO: OSLOBODITE SVOJU MOC ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Snovi o sudbini");
            Console.WriteLine("2. Odluke: put do moci");
            Console.WriteLine("3. Sila koja oblikuje Vas zivot");
            Console.WriteLine("4. Sistemi uverenja: moc da stvaramo i unistavamo");
            Console.WriteLine("5. Moze li promena da se dogodi u trenutku?");
            Console.WriteLine("6. Kako da promenite nesto u svom zivotu: nauka neuroasocijativnog uslovljavanja");
            Console.WriteLine("7. Kako da dobijete ono sto zaista zelite");
            Console.WriteLine("8. Pitanja su odgovori");
            Console.WriteLine("9. Recnik vrhunskog uspeha");
            Console.WriteLine("10. Savaladajte prepreke, srusite zid, pustite slamku i zaplesite svojim putem do uspeha: moc zivotnih metafora");
            Console.WriteLine("11. Deset emocija moci");
            Console.WriteLine("12. Velicanstvena opsesija: gradjenje primamljive buducnosti");
            Console.WriteLine("13. Desetodnevni mentalni izazov");
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

        public static void ChooseToDisplayFreeYourPowerMenu()
        {
            bool displayFreeYourPowerMenu = true;
            while (displayFreeYourPowerMenu == true)
            {
                DisplayFreeYourPower();
                string userInput = Console.ReadLine().Trim();
                displayFreeYourPowerMenu = HandleUserInputFreeYourPower(userInput);

            }
        }

        private static bool HandleUserInputFreeYourPower(string input)
        {
            switch (input)
            {
                case "1":
                    PartOneLessions.DreamsAboutDestiny();
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("2 jka");
                    Console.ReadLine();
                    return true;

                case "3":
                    Console.Clear();
                    Console.WriteLine("3 jka");
                    Console.ReadLine();
                    return true;

                case "4":
                    Console.Clear();
                    Console.WriteLine("4 ka");
                    Console.ReadLine();
                    return true;

                case "5":
                    Console.Clear();
                    Console.WriteLine("5 tica");
                    Console.ReadLine();
                    return true;

                case "6":
                    Console.Clear();
                    Console.WriteLine("6 tica");
                    Console.ReadLine();
                    return true;

                case "7":
                    Console.Clear();
                    Console.WriteLine("7 tica");
                    Console.ReadLine();
                    return true;

                case "8":
                    Console.Clear();
                    Console.WriteLine("8 tica");
                    Console.ReadLine();
                    return true;

                case "9":
                    Console.Clear();
                    Console.WriteLine("9 tka");
                    Console.ReadLine();
                    return true;

                case "10":
                    Console.Clear();
                    Console.WriteLine("10 tka");
                    Console.ReadLine();
                    return true;

                case "11":
                    Console.Clear();
                    Console.WriteLine("11 tica");
                    Console.ReadLine();
                    return true;

                case "12":
                    Console.Clear();
                    Console.WriteLine("12 tica");
                    Console.ReadLine();
                    return true;

                case "13":
                    Console.Clear();
                    Console.WriteLine("13 tica");
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
