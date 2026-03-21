using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Lessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class FreeYourPowerMenu
    {
        #region Part One  Free your power menu
        private static void DisplayFreeYourPower()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== PRVI DEO: OSLOBODITE SVOJU MOC ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Snovi o sudbini");
            System.Console.WriteLine("2. Odluke: put do moci");
            System.Console.WriteLine("3. Sila koja oblikuje Vas zivot");
            System.Console.WriteLine("4. Sistemi uverenja: moc da stvaramo i unistavamo");
            System.Console.WriteLine("5. Moze li promena da se dogodi u trenutku?");
            System.Console.WriteLine("6. Kako da promenite nesto u svom zivotu: nauka neuroasocijativnog uslovljavanja");
            System.Console.WriteLine("7. Kako da dobijete ono sto zaista zelite");
            System.Console.WriteLine("8. Pitanja su odgovori");
            System.Console.WriteLine("9. Recnik vrhunskog uspeha");
            System.Console.WriteLine("10. Savaladajte prepreke, srusite zid, pustite slamku i zaplesite svojim putem do uspeha: moc zivotnih metafora");
            System.Console.WriteLine("11. Deset emocija moci");
            System.Console.WriteLine("12. Velicanstvena opsesija: gradjenje primamljive buducnosti");
            System.Console.WriteLine("13. Desetodnevni mentalni izazov");
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

        public static void ChooseToDisplayFreeYourPowerMenu()
        {
            bool displayFreeYourPowerMenu = true;
            while (displayFreeYourPowerMenu == true)
            {
                DisplayFreeYourPower();
                string userInput = System.Console.ReadLine().Trim();
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
                    System.Console.Clear();
                    System.Console.WriteLine("2 jka");
                    System.Console.ReadLine();
                    return true;

                case "3":
                    System.Console.Clear();
                    System.Console.WriteLine("3 jka");
                    System.Console.ReadLine();
                    return true;

                case "4":
                    System.Console.Clear();
                    System.Console.WriteLine("4 ka");
                    System.Console.ReadLine();
                    return true;

                case "5":
                    System.Console.Clear();
                    System.Console.WriteLine("5 tica");
                    System.Console.ReadLine();
                    return true;

                case "6":
                    System.Console.Clear();
                    System.Console.WriteLine("6 tica");
                    System.Console.ReadLine();
                    return true;

                case "7":
                    System.Console.Clear();
                    System.Console.WriteLine("7 tica");
                    System.Console.ReadLine();
                    return true;

                case "8":
                    System.Console.Clear();
                    System.Console.WriteLine("8 tica");
                    System.Console.ReadLine();
                    return true;

                case "9":
                    System.Console.Clear();
                    System.Console.WriteLine("9 tka");
                    System.Console.ReadLine();
                    return true;

                case "10":
                    System.Console.Clear();
                    System.Console.WriteLine("10 tka");
                    System.Console.ReadLine();
                    return true;

                case "11":
                    System.Console.Clear();
                    System.Console.WriteLine("11 tica");
                    System.Console.ReadLine();
                    return true;

                case "12":
                    System.Console.Clear();
                    System.Console.WriteLine("12 tica");
                    System.Console.ReadLine();
                    return true;

                case "13":
                    System.Console.Clear();
                    System.Console.WriteLine("13 tica");
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
