using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using AnthonyRobbins.AwakenTheGiantWthin.Console;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Lessions;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Menus;


internal class Program
{
    private static void Main(string[] args)
    {
        BookBase.LoadAuthorsAndQuotes();       
        

        FrontPage();

        ChooseToDisplayMainMenu();
    }

    #region Front page and Main menu

    // prikaz prve stranice - kao hello world 
    private static void FrontPage()
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
    public static void DisplayMainMenu()
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
                ChooseToDisplayFreeYourPowerMenu();
                return true;

            case "2":
                ChooseToDisplayTakeControl();
                return true;

            case "3":
                SevenDaysMenu.ChooseToDisplaySevenDaysToShapeYourLife();
                return true;

            case "4":
                ChooseToDisplayDestinyLession();
                return true;

            case "5":
                ChooseToDisplayTechiques();
                return true;

            case "6":
                QuotesMenu.ChooseToDisplayDefinitionAndQuotes();
                return true;

            case "7":
                ChooseToDisplayPeopleAndExamples();
                return true;

            case "8":
                ChooseToDisplayNotes();
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

    private static void ChooseToDisplayFreeYourPowerMenu()
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

    private static void ChooseToDisplayTakeControl()
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
    

    #region Part Four Destiny lession
    private static void DisplayDestinyLesson()
    {
        Console.Clear();
        Console.WriteLine("==== CETVRTI DEO: POUKA O SUDBINI ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Konacni izazov: sta pojedinac moze da uradi");
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

    private static void ChooseToDisplayDestinyLession()
    {
        bool displayMenu = true;
        while (displayMenu == true)
        {
            DisplayDestinyLesson();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayDestinyLession(userInput);

        }
    }

    private static bool HandleDisplayDestinyLession(string input)
    {
        switch (input)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("26 tica");
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

    #region Part Five Techniques

    private static void DisplayTechiques()
    {
        Console.Clear();
        Console.WriteLine("==== TEHNIKE I PRAKTICNI KORACI ====");
        Console.WriteLine();
        Console.WriteLine("1. Kako da ostvarite trajnu promenu (3 koraka)");
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

    private static void ChooseToDisplayTechiques()
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
                Console.Clear();
                Console.WriteLine("1 nica");
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

    #endregion

    

    #region Part Six People and Examples 
    private static void DisplayPeopleAndExamples()
    {
        Console.Clear();
        Console.WriteLine("==== SESTI DEO: LJUDI I PRIMERI  ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Ljudi i primeri ");
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

    private static void ChooseToDisplayPeopleAndExamples()
    {
        bool displayMenu = true;
        while (displayMenu == true)
        {
            DisplayPeopleAndExamples();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayPeopleAndExamples(userInput);
        }
    }

    public static bool HandleDisplayPeopleAndExamples(string input)
    {
        switch (input)
        {
            case "1":
                Console.Clear();
                PartOneLessions.People();
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




