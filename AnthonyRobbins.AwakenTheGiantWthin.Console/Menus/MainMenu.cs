using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class MainMenu
    {

        #region Front page and Main menu

        // prikaz prve stranice - kao hello world 
        public static void FrontPage()
        {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("===============================================================");
            System.Console.WriteLine(" \"Posvećeno neograničenoj moći koja leži uspavana u Vama.\"");
            System.Console.WriteLine("  \"Ne dozvolite joj da i dalje drema. \"");
            System.Console.WriteLine("                              - Tony Robbins");
            System.Console.WriteLine("===============================================================");
            System.Console.ResetColor();
            System.Console.WriteLine();
            System.Console.WriteLine("Hello people to fabolous book of  Tony Robbins");
            System.Console.WriteLine();
            System.Console.WriteLine("         --   Awaken the giant within  -- ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Press ENTER to start");
            System.Console.WriteLine();
            System.Console.ReadLine();
        }
        // while petlja zaduzena za ispis pocetnog menija 
        public static void ChooseToDisplayMainMenu()
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
                DisplayMainMenu();

                string userInput = System.Console.ReadLine().Trim();

                displayMenu = HandleUserInput(userInput);
            }
        }

        // pocetni - glavni meni 
        private static void DisplayMainMenu()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== GLAVNI MENU: PROBUDITE DIVA U SEBI ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Oslobodite svoju moc");
            System.Console.WriteLine("2. Preuzimanje kontrole - glavni sistem ovladavanja");
            System.Console.WriteLine("3. Sedam dana za oblikovanje vaseg zivota");
            System.Console.WriteLine("4. Pouka o sudbini");
            System.Console.WriteLine("5. Tehnike (prakticni koraci)");
            System.Console.WriteLine("6. Definicije i citati");
            System.Console.WriteLine("7. Ljudi i primeri iz knjige");
            System.Console.WriteLine("8. Vase beleske");
            System.Console.WriteLine("0. Izlaz iz programa");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Unesite opciju: ");
        }


        // odabir gde ce korisnik da se prebaci na osnovu inputa, da li ostaje na tom istom , da je li je greska, ili vec napusta program 
        private static bool HandleUserInput(string input)
        {

            switch (input)
            {
                case "1":
                    FreeYourPowerMenu.ChooseToDisplayFreeYourPowerMenu();

                    return true;

                case "2":
                    TakeControlMenu.ChooseToDisplayTakeControl();
                    return true;

                case "3":
                    SevenDaysMenu.ChooseToDisplaySevenDaysToShapeYourLife();
                    return true;

                case "4":
                    DestinyLessionMenu.ChooseToDisplayDestinyLession();
                    return true;

                case "5":
                    TechniquesMenu.ChooseToDisplayTechiques();
                    return true;

                case "6":
                    QuotesMenu.ChooseToDisplayDefinitionAndQuotes();
                    return true;

                case "7":
                    PeopleAndExamplesMenu.ChooseToDisplayPeopleAndExamples();
                    return true;

                case "8":
                    NotesMenu.ChooseToDisplayNotes();
                    return true;

                case "0":
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
