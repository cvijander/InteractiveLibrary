internal class Program
{
    private static void Main(string[] args)
    {
        FrontPage();        

        ChooseToDisplayMainMenu();        
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
            
            ChooseToDisplayFreeYourPowerMenu();
            return true;
        }
        else if (input == "2")
        {
            ChooseToDisplayTakeControl();
            return true;
        }
        else if (input == "3")
        {
            ChooseToDisplaySevenDaysToShapeYourLife();
            return true;
        }
        else if (input == "4")
        {
            ChooseToDisplayDestinyLession();
            return true;
        }
        else if (input == "5")
        {
            ChooseToDisplayDefinitionAndQuotes();
            return true;
        }
        else if (input == "6")
        {
            ChooseToDisplayPeopleAndExamples();   
             return true;
        }
        else if (input == "7")
        {
            ChooseToDisplayNotes();
            return true;
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
        if (input == "1")
        {
            Console.Clear();
            Console.WriteLine("Returnig false");
            Console.ReadLine();
            return true;

        } else if (input == "2")
        {
            return true;
        


        } else if (input == "0")
        {
            return false;
        }

        else
        {
            ErrorMessage();
            return true;
        }
    }
    private static void DisplayTakeControl()
    {
        Console.Clear();
        Console.WriteLine("==== DRUGI DEO: PREUZIMANJE KONTROLE - GLAVNI SISTEM OVLADAVANJA ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("14. Elementarni uticaj: vas glavni sistem");
        Console.WriteLine("15. Zivotne vrednosti: licni kompas");
        Console.WriteLine("16. Pravila: evo zasto niste srecni");
        Console.WriteLine("17. Asocijacije: tkanina zivota");
        Console.WriteLine("18. Identitet: kljuc za expanziju");
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

    private static void  ChooseToDisplayTakeControl()
    {
        bool displayMenu = true;

        while(displayMenu == true)
        {
            DisplayTakeControl();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayTakeControl(userInput);
        }
        
    }

    private static bool HandleDisplayTakeControl(string input)
    {
        if (input == "14")
        {
            Console.Clear();
            Console.WriteLine("Evo nas ovde ");
            Console.ReadLine();
            return true;
        }
        else if (input == "0")
        {
            return false;
        }
        else if (input == "99")
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

    private static void DisplaySevenDaysToShapeYourLife()
    {
        Console.Clear();
        Console.WriteLine("==== TRECI DEO: SEDAM DANA ZA OBLIKOVANJE VASEG ZIVOTA ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("19. Emocijonalna sudbina: jedini istinski uspeh");
        Console.WriteLine("20. Telesna sudbina: tamnica bola ili plata zadovoljstva");
        Console.WriteLine("21. Sudbina veza: mesto za deljenje i ljubav");
        Console.WriteLine("22. Finansijska sudbina: mali koraci do malog ili velikog bogatstva");
        Console.WriteLine("23. Budite besprekorni: vas kodeks ponasanja");
        Console.WriteLine("24. Ovladajte svojim vremenom i svojom sudbinom");
        Console.WriteLine("25. Odmarajte se i zabavljajte: cak je i bog uzeo slobodan dan");
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

    private static void ChooseToDisplaySevenDaysToShapeYourLife()
    {
        bool displayMenu = true;
        while(displayMenu == true)
        {
            DisplaySevenDaysToShapeYourLife();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplaySevenDaysToShapeYourLife(userInput);
        }
    }

    private static bool HandleDisplaySevenDaysToShapeYourLife(string input)
    {
        if (input == "19")
        {
            Console.Clear();
            Console.WriteLine("Ovde smo");
            Console.ReadLine();
            return true;
        }
        else if (input == "0")
        {
            return false;
        }
        else if (input == "99")
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

    private static void DisplayDestinyLesson()
    {
        Console.Clear();
        Console.WriteLine("==== CETVRTI DEO: POUKA O SUDBINI ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("26. Konacni izazov: sta pojedinac moze da uradi");
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
        while(displayMenu == true)
        {
            DisplayDestinyLesson();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayDestinyLession(userInput);

        }
    }

    private static bool HandleDisplayDestinyLession(string input)
    {
        if ( input == "26")
        {
            Console.Clear();
            Console.WriteLine("26 tivca");
            Console.ReadLine();
            return true;
        }
        else if (input == "0")
        {
            return false;
        }
        else if (input == "99")
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

    private static void DisplayDefinitionsAndQuotes()
    {
        Console.Clear();
        Console.WriteLine("==== PETI DEO: DEFINICIJE I CITATI ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("27. Definicije i citati");
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

    public static void ChooseToDisplayDefinitionAndQuotes()
    {
        bool displayMenu = true;
        while(displayMenu == true)
        {
            DisplayDefinitionsAndQuotes();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayDefinitionsAndQuotes(userInput);
        }
    }

    private static bool HandleDisplayDefinitionsAndQuotes(string input)
    {
        if (input == "27")
        {
            Console.Clear();
            Console.WriteLine("27 ca");
            Console.ReadLine();
            return true;
        }
        else if (input == "0")
        {
            return false;
        }
        else if (input == "99")
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

    private static void DisplayPeopleAndExamples()
    {
        Console.Clear();
        Console.WriteLine("==== SESTI DEO: LJUDI I PRIMERI  ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("28. Ljudi i primeri ");
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
        if (input == "28")
        {
            Console.Clear();
            Console.WriteLine("28 tica ");
            Console.ReadLine();
            return true;
        }
        else if (input == "0")
        {
            return false;
        }
        else if (input == "99")
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

    private static void DisplayNotes()
    {
        Console.Clear();
        Console.WriteLine("==== SEDMI DEO: VASE BELESKE  ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("29. Beleske ");
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

    private static void ChooseToDisplayNotes()
    {
        bool displayMenu = true;

        while(displayMenu == true)
        {
            DisplayNotes();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayNotes(userInput);

        }
    }

    private static bool HandleDisplayNotes(string input)
    {
        if (input == "29")
        {
            Console.Clear();
            Console.WriteLine("29 tka");
            return true;
        }
        else if (input == "0")
        {
            return false;
        }
        else if (input == "99")
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

    private static void ExitProgram()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hvala sto ste koristili ovaj program. Nadamo se da vam je pomogao da probudite diva u sebi!");
        Console.WriteLine("Pritisnite ENTER za izlaz.");
        Console.ResetColor();
        Console.ReadLine();

        Environment.Exit(0);
    }

    private static void ErrorMessage()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Molimo pritisnite ENTER i ponovo odaberite ali samo neku od ponudjenih opcija.");
        Console.ResetColor();
        Console.ReadLine();
    }

    
}