internal class Program
{
    private static void Main(string[] args)
    {
        FrontPage();


        DisplayMenu();

    }

    private static void FrontPage()
    {
        Console.Clear();
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

    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("==== GLAVNI MENU: PROBUDITE DIVA U SEBI ===");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Oslobodite svoju moc");
        Console.WriteLine("2. Preuzimanje kontrole - glavni sistem ovladavanja");
        Console.WriteLine("3. Sedam dana za oblikovanje vaseg zivota");
        Console.WriteLine("4. Pouka o sudbini");
        Console.WriteLine("5. Definicije i citati");
        Console.WriteLine("6. Ljudi i primeri iz knjige");
        Console.WriteLine("7  Vase beleske");
        Console.WriteLine("0  Izlaz iz programa" );
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Unesite opciju: ");
        string userInput = Console.ReadLine().Trim();

        bool userOption = true;
        // TRIM

        userOption = HandleUserInput(userInput);
        while (!userOption)
        {
            DisplayMenu();
        }



    }

    private static bool HandleUserInput(string input)
    {
        if (input == "1")
        {
            FreeYourPower();
            return true;
        }
        else if (input == "2")
        {
            TakeControl();
            return true;
        }
        else 
        {
            ErrorMessage();
            return false;
        }
    }

    private static void FreeYourPower()
    {
        Console.Clear();
        Console.WriteLine("1");
    }
    private static void TakeControl()
    {
        Console.Clear();
        Console.WriteLine("2");
    }

    private static void ErrorMessage()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Molimo pritisnite ENTER i ponovo odaberite ali samo neku od ponudjenih opcija.");
        Console.ResetColor();
        Console.ReadLine();
    }
}