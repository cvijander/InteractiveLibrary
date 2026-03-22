using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class MainMenu
    {

        #region Front page and Main menu

        // prikaz prve stranice - kao hello world 
        public static void FrontPage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================================================");
            Console.WriteLine(" \"Posvećeno neograničenoj moći koja leži uspavana u Vama.\"");
            Console.WriteLine("  \"Ne dozvolite joj da i dalje drema. \"");
            Console.WriteLine("                              - Tony Robbins");
            Console.WriteLine("===============================================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Hello people to fabolous book of  Tony Robbins");
            Console.WriteLine();
            Console.WriteLine("         --   Awaken the giant within  -- ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to start");
            Console.WriteLine();
            Console.ReadLine();
        }
        // while petlja zaduzena za ispis pocetnog menija 
        public static void ChooseToDisplayMainMenu()
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
                DisplayMainMenu();

                string userInput = Console.ReadLine().Trim();

                displayMenu = HandleUserInput(userInput);
            }
        }

        // pocetni - glavni meni 
        private static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("==== GLAVNI MENU: PROBUDITE DIVA U SEBI ====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Oslobodite svoju moc");
            Console.WriteLine("2. Preuzimanje kontrole - glavni sistem ovladavanja");
            Console.WriteLine("3. Sedam dana za oblikovanje vaseg zivota");
            Console.WriteLine("4. Pouka o sudbini");
            Console.WriteLine("5. Tehnike (prakticni koraci)");
            Console.WriteLine("6. Definicije i citati");
            Console.WriteLine("7. Ljudi i primeri iz knjige");
            Console.WriteLine("8. Vase beleske");
            Console.WriteLine("0. Izlaz iz programa");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Unesite opciju: ");
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
