using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using AnthonyRobbins.AwakenTheGiantWthin.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Author testAutor = new Author();
        Console.WriteLine("-- saljemo samo razmake --");
        testAutor.Name = "   ";
        Console.WriteLine($"Resultat u bazi {testAutor.Name}");
        Console.WriteLine();

        Console.WriteLine("-- Test saljemo kratko ime");
        testAutor.Name = "ab";
        Console.WriteLine($"Resultat u bazi {testAutor.Name}");
        Console.WriteLine();

        Console.WriteLine("Test 3 saljemo ime sa velikim i malim slovima ");
        testAutor.Name = "anThoNY";
        Console.WriteLine($"Resultat u bazi {testAutor.Name}");
        Console.WriteLine();
        Console.ReadLine();


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
                ChooseToDisplaySevenDaysToShapeYourLife();
                return true;

            case "4":
                ChooseToDisplayDestinyLession();
                return true;

            case "5":
                ChooseToDisplayTechiques();
                return true;

            case "6":
                ChooseToDisplayDefinitionAndQuotes();
                return true;

            case "7":
                ChooseToDisplayPeopleAndExamples();
                return true;

            case "8":
                ChooseToDisplayNotes();
                return true;

            case "0":
                ExitProgram();
                return false;

            default:
                ErrorMessage();
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
                DreamsAboutDestiny();
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
                ExitProgram();
                return false;

            default:
                ErrorMessage();
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
                ExitProgram();
                return false;

            default:
                ErrorMessage();
                return true;
        }

    }

    #endregion

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

    private static void ChooseToDisplaySevenDaysToShapeYourLife()
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
                ExitProgram();
                return false;

            default:
                ErrorMessage();
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
                ExitProgram();
                return false;

            default:
                ErrorMessage();
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
                ExitProgram();
                return false;

            default:
                ErrorMessage();
                return true;
        }
    }
    #endregion

    #endregion

    #region Part Five Definitions and quotes 
    private static void DisplayDefinitionsAndQuotes()
    {
        Console.Clear();
        Console.WriteLine("==== PETI DEO: DEFINICIJE I CITATI ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Definicije i citati");
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
        while (displayMenu == true)
        {
            DisplayDefinitionsAndQuotes();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayDefinitionsAndQuotes(userInput);
        }
    }

    private static bool HandleDisplayDefinitionsAndQuotes(string input)
    {
        switch (input)
        {
            case "1":
                Console.Clear();
                Quotes();
                Console.ReadLine();
                return true;              
                               

            case "0":
                return false;

            case "99":
                ExitProgram();
                return false;

            default:
                ErrorMessage();
                return true;
        }

    }

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
                People();
                Console.ReadLine();
                return true;

            case "0":
                return false;

            case "99":
                ExitProgram();
                return false;

            default:
                ErrorMessage();
                return true;
        }

    }

    #endregion

    #region Part Seven Notes
    private static void DisplayNotes()
    {
        Console.Clear();
        Console.WriteLine("==== OSMI DEO: VASE BELESKE  ====");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Beleske ");
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

        while (displayMenu == true)
        {
            DisplayNotes();
            string userInput = Console.ReadLine().Trim();
            displayMenu = HandleDisplayNotes(userInput);

        }
    }

    private static bool HandleDisplayNotes(string input)
    {
        switch (input)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Unesite vase beleske, ovde, te iste beleske videce u text fajlu nazvan \"KorisnickeBeleske.txt\"");
                string beleske = "";
                string userInput = Console.ReadLine();
                beleske = beleske + "\n" + userInput;

                System.IO.File.AppendAllText(@"D:\Dev\csharp\InteractiveLibrary\AnthonyRobbins.AwakenTheGiantWthin.Console\KorisnickeBeleske.txt", beleske);
                return true;

            case "0":
                return false;

            case "99":
                ExitProgram();
                return false;

            default:
                ErrorMessage();
                return true;
        }

    }

    #endregion

    #region ExitProgram and ErrorMessage 
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
    #endregion

    #region Part One Lessions
    private static void DreamsAboutDestiny()
    {
        Console.Clear();
        Console.WriteLine("==== 1. SNOVI O SUDBINI ( Strana 1 )  ====");
        Console.WriteLine();
        Console.WriteLine("Vidim mnogo ljudske patnje, ne samo kod mentalnih bolesnika koje lecimo vec i kod \"normalnog\", \"zdravog\" osoblja koje se brine o pacijentima.");
        Console.WriteLine("Istu nesrecu vidim kod izuzetno funkcionalnih, relativno uspesnih ljudi koje lecim u svojoj privatnoj ordinaciji.");
        Console.WriteLine("Cesto su bol i patnja nepotrebni i konacno prestanu kada ljudi preuzmu kontrolu nad svojim uverenjima, osecanjima i postupcima kako bi preinacili proces svog zivota. ");
        Console.WriteLine("Nazalost, u vecini slucajeva oni to ne cine, cekaju , zatim pokusavaju da promene los rezultat ili odlaze kod psihijatra zeleci samo da se pozale na svoj ocajan zivot ili da ih na neki nacin neko drugi \"popravi\"");
        Console.WriteLine();
        Console.WriteLine("Osposobljavanje ljudi da shvate da sami odredjuju rezultat sopstevenih zivota nije uvek lako.Zapravo to je iscrpljujuci zadatak.");
        Console.WriteLine("Neocekivana je bila Tonijeva genijalnost u oblasti ljudskog ponasanja i komunikacije. Te veceri sam shvatio da Toni deli moje uverenje da svako koje u osnovi zdrav , moze da preuzme komande i zivi ispunje zivot.");
        Console.WriteLine();
        OrisonSvetMarden().ShowQuote();
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();


        Console.Clear(); 
        Console.WriteLine("==== 1. SNOVI O SUDBINI ( Strana 2 )  ====");
        Console.WriteLine();
        BendzaminDizraeli().ShowQuote();
        Console.WriteLine();
        Console.WriteLine("Svi imamo snove... Svi duboko u svojim dusama zelim da imamo poseban dar; da mozemo da ostvarimo znacajne promene, da uticemo na druge na poseban nacin");
        Console.WriteLine("Da ucinimo da svet postane bolje mesto. Svi smo ponekad imali viziju o kvalitetu zivota koji prizeljkujemo i zasluzujemo.");
        Console.WriteLine();
        Console.WriteLine("Ipak, za mnoge od nas, ti snovi postali su toliko prekriveni frustracijama i dnevnom rutinom da vise i ne pokusavamo da ih ostvarimo.");
        Console.WriteLine("Kod previse ljudi rasprsilo se taj SAN, a s njima i VOLJA da preoblikujemo svoju sudbinu.");
        Console.WriteLine("Mnogi su izgubiuli osecaj sigurnosti koji stvara POBEDNICKI DUH.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Moj zivotni cilj bio je da povratim taj san i ucinim ga stvarnim, da svakoga od nas podstaknem da se seti i koristi neogranicenu moc koja spava unutar nas. ");
        Console.ResetColor();
        Console.WriteLine();
        AnthonyRobbins1().ShowQuote();
        Console.WriteLine();
        Console.WriteLine("Tada sam imao snove, ali cinilo se da se nikada nece ostvariti. Medjutim danas verujem da su svi moji protekli neuspesi i frustracije postavljali temelj za saznanja koja su ");
        Console.WriteLine("stvaril novi nivo ziljvenja u kojem sada uzivam.");
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("==== 1. SNOVI O SUDBINI ( Strana 3 )  ====");
        Console.WriteLine();
        People();
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("==== 1. SNOVI O SUDBINI ( Strana 4 )  ====");
        Console.WriteLine();
        Console.WriteLine("Takodje se secam trenutka kada se moj zivot promenio, trenutka kada sam napokon rekao: ");
        AnthonyRobbins2().ShowQuote();
        Console.WriteLine();
        Console.WriteLine("Tog trenutka sam doneo odluku da zauvek promeni svoj zivot. Odlucio sam da proimenim svaki aspekt svog zivota.");
        Console.WriteLine("Odlucio sam da se nikada vise necu zadovoljiti manjim od onoga sto mogu da budem.");
        Console.WriteLine("Moj odgovor je jednostavan: naucio sam da primenjujem princip koji se sada nazivam \" koncentracijom moci \" ");
        Console.WriteLine("Vecina ljudi nema nikakvu predstavu o divovskom kapacitetu kojim mozemo odmah da upravljamo kada usresredimo sve svoje resurse na ovladavanje");
        Console.WriteLine("samo jednom oblascu u svom zivotu. ");
        AnthonyRobbins3().ShowQuote();
        Console.WriteLine();
        AnthonyRobbins4().ShowQuote();
        Console.WriteLine("Verujem da vecina ljudi ne uspe u zivotu zbog toga sto ovlada nebitnim stvarima");
        Console.WriteLine();
        AnthonyRobbins5().ShowQuote();
        Console.WriteLine();
        AnthonyRobbins6().ShowQuote();
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("==== 1. SNOVI O SUDBINI ( Strana 5 )  ====");
        Console.WriteLine();
        AnthonyRobbins7().ShowQuote();
        Console.WriteLine();
        Console.WriteLine("Kroz ceo taj proces nastavio sam da prepoznajem moc koji imaju pojednici, da promene prakticno sve u svojim zivotima u samo jedno trenutku");
        Console.WriteLine("Naucio sam da su sredstva koja su nam potreban da ostvarimo svoje snove u nama i da samo cekaju dan kada cemo odluciti da se probudimo i ostvarimo pravo dobijeno rodjenjem");
        Console.WriteLine("Poziv na budjenje koji ce podstaci one koji su posveceni tome da bolje zive i vise streme svojoj bogom danoj moci.");
        Console.WriteLine();
        AnthonyRobbins8().ShowQuote();
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();


        Console.Clear();
        Console.WriteLine("==== 1. SNOVI O SUDBINI ( Strana 6 )  ====");
        Console.WriteLine();
        HowToMakeAPermanentChange();
        Console.WriteLine();       
       
        GoToNextPage();
        Console.ReadLine();

    }

    #endregion

    #region Part Five Quotes 

    private static void Quotes()
    {
        List<Author> allAuthors = new List<Author>();

        Author antony = new Author("Anthony Robbins","Americki autor");
        Author orison = new Author("Orison Svet Marden", "Ovo dodati");
        Author benzaminDizraeli = new Author("Bendzamin Dizraeli", "Ovo dodati");

        antony.hisQuotes.Add(AnthonyRobbins1());
        antony.hisQuotes.Add(AnthonyRobbins2());
        antony.hisQuotes.Add(AnthonyRobbins3());
        antony.hisQuotes.Add(AnthonyRobbins4());
        antony.hisQuotes.Add(AnthonyRobbins5());
        antony.hisQuotes.Add(AnthonyRobbins6());
        antony.hisQuotes.Add(AnthonyRobbins7());
        antony.hisQuotes.Add(AnthonyRobbins8());


        orison.hisQuotes.Add(OrisonSvetMarden());

        benzaminDizraeli.hisQuotes.Add(BendzaminDizraeli());

        allAuthors.Add(antony);
        allAuthors.Add(orison);
        allAuthors.Add(benzaminDizraeli);

        foreach (Author author in allAuthors)
        {

        }

        List<Quote> allQuotes = new List<Quote>()
        { OrisonSvetMarden(),
          BendzaminDizraeli(),
          AnthonyRobbins1(),
          AnthonyRobbins2(),
          AnthonyRobbins3(),
          AnthonyRobbins4(),
        };



        allQuotes.Add(AnthonyRobbins5());
        allQuotes.Add(AnthonyRobbins6());
        allQuotes.Add(AnthonyRobbins7());
        allQuotes.Add(AnthonyRobbins8());

        foreach (Quote quote in allQuotes)
        {
            quote.ShowQuote();
        }

    }

    private static Quote OrisonSvetMarden()
    {
        Quote quote = new Quote();
        //OrisonSvetMarden1.Author = "Orison Svet Marden";
        quote.Text = "\"Duboko unutar coveka obitavaju te uspavane moci; \nmoci koji bi ga zacudile, jer nikada nije sanjao da ih poseduje;\n sile koje bi, ako bi bile probudjene i pokrenute, nacinile preokret u njegovom zivotu. \"";
        quote.Color = ConsoleColor.Yellow;
                
        return quote;         
    }

    private static Quote BendzaminDizraeli()
    {
        Quote quote = new Quote();
        //BendzaminDizraeli1.Author = "Bendzamin Dizraeli";
        quote.Text = " Dosledan covek veruje u sudbinu, \n a nepredvidiv u priliku.";
        quote.Color = ConsoleColor.Yellow;

        return quote;        
    }

    private static Quote AnthonyRobbins1()
    {
        Quote quote = new Quote();
       // AnthonyRobbins1.Author = "Anthony Robbins";
        quote.Text = "\" Kakvu razliku jedna decenija moze da napravi! \" ";
        quote.Color = ConsoleColor.Yellow;

        return quote;       
    }

    private static Quote AnthonyRobbins2()
    {
        Quote quote = new Quote();
       // AnthonyRobbins2.Author = "Anthony Robbins";
        quote.Text = " \" Dosta je bilo! Znam da sam mnogo vise od onoga sto pokazujem u mentalnom, emocionalnom i telesnom apsktu svog zivota.\" ";
        quote.Color = ConsoleColor.Yellow;

        return quote;
    }
    private static Quote AnthonyRobbins3()
    {
        Quote quote = new Quote();
        // AnthonyRobbins3.Author = "Anthony Robbins";
        quote.Text = " \"Kontrolisani fokus je kao laserski zrak koji moze da presece sve sto vas naizgled zaustavlja.\"";
        quote.Color = ConsoleColor.Yellow;

        return quote;
    }

    private static Quote AnthonyRobbins4()
    {
        Quote quote = new Quote();
        //AnthonyRobbins4.Author = "Anthony Robbins";
        quote.Text = " \"Kada se istrajno usresredjujemo na poboljsanje bilo koje oblasti razvijamo jedinstvene distinkcije o nacinu kako da ucinimo tu ideju boljom. \n Jedan od razloga sto tako mali broj nas postigne ono sto zaista zeli jeste taj sto nikada ne usmeri svoj fokus; nikada ne koncentrise svoju moc.";
        quote.Color = ConsoleColor.Yellow;

        return quote;
    }

    private static Quote AnthonyRobbins5()
    {
        Quote quote = new Quote();
        //AnthonyRobbins5.Author = "Anthony Robbins";
        quote.Text = " Sta cini razliku u kvalitetu ljudskih zivota? Kako to da cesto ljudi sa skromnim pocecicma i iz opustosenih sredina ,uprkos svemu, uspevaju da stvore zivote koji nas inspirisu?  \n Nasuprot tome, zasto mnogi koji su rodjeni u privilegovanom sredinama, sa svim sredstvima nadohvat ruke , zavrse debeli, frustrirani i cesto zavisni od neke hemijska supstance. \n Koja je to tajna koja stvara strastveni, srecan i zahvalna zivot kod mnogih, dok bi kod drugih refren mogoa da zvuci ovako \"Da li je to sve \"";
        quote.Color = ConsoleColor.Yellow;

        return quote;
    }

    private static  Quote AnthonyRobbins6()
    {
        Quote quote = new Quote();
       // AnthonyRobbins6.Author = "Anthony Robbins";
        quote.Text = "\"Kako mogu da preuzmem naposrednu kontrolu nad svojim zivotom ? \n  Sta mogu da uradim danas sto moze napraviti razliku - nesto sto bi pomoglo meni i drugima da oblikujemo svoje sudbine? \nKako mogu da se razvijma , ucim , rastem i delim ta saznanja s drugim na smislen i ugodan nacin. ";
        quote.Color = ConsoleColor.Yellow;

        return quote;        
    }

    private static Quote AnthonyRobbins7()
    {

        Quote quote = new Quote();
        //AnthonyRobbins7.Author = "Anthony Robbins";
        quote.Text = "Kod mene se veoma rano u zivotu razvilo uverenje da smo svi ovde da bismo doprineli necim jedinstvenim, da duboko u nama lezi poseban dar.\n \n Ja zaista verujem da u svakome od nas spava DIV \n Svako od nas poseduje neki talenat, dar , vlastitit komaci genijalnosti koji ceka da bude dotaknut.\nTo moze da bude talenat za umetnost ili muziku. To moze biti specifican nacin na koji se odnosite prema onima koje volite.\nTo moze biti genijalan dar za prodaju, inovacije, ili uspeh u poslu ili karijeri.\");";
        quote.Color = ConsoleColor.Yellow;

        return quote;
    }

    private static Quote AnthonyRobbins8()
    {
        Quote quote = new Quote();
        //AnthonyRobbins8.Author = "Anthony Robbins";
        quote.Text = "Vi ste predodredjeni za sopstveni jednistveni oblik izvrsnosti, bez obzira na to da li je to uloga izvanrednog strucnjaka, ucitelja, poslovnog coveka, majke ili oca. \n Ne samo da verujete u to , vec ste i preduzeli akciju\"";
        quote.Color = ConsoleColor.Yellow;

        return quote;
    }
    #endregion


    private static void GoToNextPage()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Pritisnite ENTER za sledecu stranu...");
        Console.ResetColor();
    }

    #region People 

    private static void People()
    {
        Story1();
        Console.WriteLine();
        Console.WriteLine(" -------------------- ");
        Console.WriteLine();
        Story2();
        Console.WriteLine();
        Console.WriteLine(" -------------------- ");
        Console.WriteLine();
        Story3();
        Console.WriteLine();
        Console.WriteLine(" -------------------- ");
        Console.WriteLine();
        Story4();
        Console.WriteLine();
        Console.WriteLine(" -------------------- ");
        Console.WriteLine();
        Story5();
        Console.WriteLine();
        Console.WriteLine(" -------------------- ");
        Console.WriteLine();
        Story6();
        Console.WriteLine();
        Console.WriteLine(" -------------------- ");
        Console.WriteLine();

    }

    private static void Story1()
    {
        Console.WriteLine("Jedna majka me je upoznala sa svojim sinom koji je dobio dijagnozu da je hiperaktivan i nesposoban da uci");
        Console.WriteLine("Primenjujuci principe \"Upravljanja stanjima \" koji se uvec, ona nije samo uspela da ga odvikne od leka ratalina  vec su bili i prebaceni  ");
        Console.WriteLine("u Kaliforniju gde su njenog sina ponovo testirali i ocenjeno je da je na nivou genija");
        
    }

    private static void Story2()
    {
        Console.WriteLine("Jedan gospodin se oslobodio upotrebe kokaina tako sto je primenjivao neke od tehnika \" Uslovljanjvanja uspeha \"");
    }

    private static void Story3()
    {
        Console.WriteLine("Jedan par je  bio na ivici razvoda dok nije savladao \"Licna pravila \" ");
    }

    private static void Story4()
    {
        Console.WriteLine("Jedan trgovac mi je rekao da je njegov mesecni dohodak skocio sa 2000 dolara na 12000 za samo sest meseci");
    }

    private static void Story5()
    {
        Console.WriteLine("Jedan preduzetnik ispiricao mi je da je za osamnaest meseci uvecao prihode svog preduzeca za vise od tri miliona dolara tako sto je primenjivao ");
        Console.WriteLine("\" Princiepe kvalitativnih pitanja i upravljanja emocijama \"");
    }

    private static void Story6()
    {
        Console.WriteLine("Divna mlada zena pokazala mi je svoju fotografiju iz perioda pre nego sto je izgubila 22 kilograma tako sto je primenjivala principe dejstva \"poluge\"");
    }


    #endregion

    private static void HowToMakeAPermanentChange()
    {
        Console.Clear();
        Console.WriteLine("==== KAKO DA OSTVARIMO TRAJNU PROMENU ====");
        Console.WriteLine("");
        GoToNextPage();
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("==== PRVI KORAK : PODIGNITE SVOJE STANDARDE");
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("==== DRUGI KORAK : PROMENITE UVERENJA KOJA VAS OGRANICAVAJU");
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();

        StepThreeChangeYourStrategy();

    }

    private static void StepThreeChangeYourStrategy()
    {
        Console.Clear();
        Console.WriteLine("==== TRECI KORAK : PROMENITE SVOJU STRATEGIJU ====");
        Console.WriteLine();
        GoToNextPage();
        Console.ReadLine();
    }

}




