internal class Program
{
    private static void Main(string[] args)
    {
        FrontPage();

        

        ChooseToDisplayMenu();

        

    }

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

    public static void ChooseToDisplayMenu()
    {
        bool displayMenu = true;       

        while (displayMenu == true)
        {
            DisplayMainMenu();

            string userInput = Console.ReadLine().Trim();

               displayMenu = HandleUserInput(userInput);
        }
    }
                

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
        Console.WriteLine("5. Definicije i citati");
        Console.WriteLine("6. Ljudi i primeri iz knjige");
        Console.WriteLine("7. Vase beleske");
        Console.WriteLine("0. Izlaz iz programa");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Unesite opciju: ");
    }

    

    private static bool HandleUserInput(string input)
    {
        if (input == "1")
        {
            FreeYourPower();
            return false;
        }
        else if (input == "2")
        {
            TakeControl();
            return false;
        }
        else if (input == "3")
        {
            SevenDaysToShapeYourLife();
            return false;
        }
        else if (input == "4")
        {
            DestinyLesson();
            return false;
        }
        else if (input == "5")
        {
             DefinitionsAndQuotes();
            return false;
        }
        else if (input == "6")
        {
             PeopleAndExamples();   
             return false;
        }
        else if (input == "7")
        {
             Notes();
            return false;
        }
        else if (input == "0")
        {
             ExitProgram();
            return false;
        }
        else 
        {
            ErrorMessage();
            return true;
        }
    }

    private static void FreeYourPower()
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
        Console.Write("Unesite opciju: ");
        Console.WriteLine();
        Console.WriteLine();
    }
    private static void TakeControl()
    {
        Console.Clear();
        Console.WriteLine("2");
    }

    private static void SevenDaysToShapeYourLife()
    {
        Console.Clear();
        Console.WriteLine("3");
    }

    private static void DestinyLesson()
    {
        Console.Clear();
        Console.WriteLine("4");
    }

    private static void DefinitionsAndQuotes()
    {
        Console.Clear();
        Console.WriteLine("5");
    }

    private static void PeopleAndExamples()
    {
        Console.Clear();
        Console.WriteLine("6");
    }

    private static void Notes()
    {
        Console.Clear();
        Console.WriteLine("7");
    }

    private static void ExitProgram()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hvala sto ste koristili ovaj program. Nadamo se da vam je pomogao da probudite diva u sebi!");
        Console.WriteLine("Pritisnite ENTER za izlaz.");
        Console.ResetColor();
        Console.ReadLine();
    }

    private static void ErrorMessage()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Molimo pritisnite ENTER i ponovo odaberite ali samo neku od ponudjenih opcija.");
        Console.ResetColor();
        Console.ReadLine();
    }
}