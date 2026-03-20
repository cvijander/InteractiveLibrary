using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console
{
    public static class BookBase
    {
        public static List<Author> AllAuthors = new List<Author>();

        public static Quote OrisonSvetMarden1 = new Quote("\"Duboko unutar coveka obitavaju te uspavane moci; \nmoci koji bi ga zacudile, jer nikada nije sanjao da ih poseduje;\n sile koje bi, ako bi bile probudjene i pokrenute, nacinile preokret u njegovom zivotu. \"" ,ConsoleColor.Yellow);

        public static Quote BendzaminDizraeli1 = new Quote(" Dosledan covek veruje u sudbinu, \n a nepredvidiv u priliku." ,ConsoleColor.Yellow);

        public static Quote AnthonyRobbins1 = new Quote("\" Kakvu razliku jedna decenija moze da napravi! \" " ,ConsoleColor.Yellow);

        public static Quote AnthonyRobbins2 = new Quote(" \" Dosta je bilo! Znam da sam mnogo vise od onoga sto pokazujem u mentalnom, emocionalnom i telesnom apsktu svog zivota.\" ", ConsoleColor.Yellow);

        public static Quote AnthonyRobbins3 = new Quote(" \"Kontrolisani fokus je kao laserski zrak koji moze da presece sve sto vas naizgled zaustavlja.\"", ConsoleColor.Yellow);

        public static Quote AnthonyRobbins4 = new Quote(" \"Kada se istrajno usresredjujemo na poboljsanje bilo koje oblasti razvijamo jedinstvene distinkcije o nacinu kako da ucinimo tu ideju boljom. \n Jedan od razloga sto tako mali broj nas postigne ono sto zaista zeli jeste taj sto nikada ne usmeri svoj fokus; nikada ne koncentrise svoju moc.", ConsoleColor.Yellow);

        public static Quote AnthonyRobbins5 = new Quote(" Sta cini razliku u kvalitetu ljudskih zivota? Kako to da cesto ljudi sa skromnim pocecicma i iz opustosenih sredina ,uprkos svemu, uspevaju da stvore zivote koji nas inspirisu?  \n Nasuprot tome, zasto mnogi koji su rodjeni u privilegovanom sredinama, sa svim sredstvima nadohvat ruke , zavrse debeli, frustrirani i cesto zavisni od neke hemijska supstance. \n Koja je to tajna koja stvara strastveni, srecan i zahvalna zivot kod mnogih, dok bi kod drugih refren mogoa da zvuci ovako \"Da li je to sve \"", ConsoleColor.Yellow);

        public static Quote AnthonyRobbins6 = new Quote("\"Kako mogu da preuzmem naposrednu kontrolu nad svojim zivotom ? \n  Sta mogu da uradim danas sto moze napraviti razliku - nesto sto bi pomoglo meni i drugima da oblikujemo svoje sudbine? \nKako mogu da se razvijma , ucim , rastem i delim ta saznanja s drugim na smislen i ugodan nacin. ", ConsoleColor.Yellow);

        public static Quote AnthonyRobbins7 = new Quote("Kod mene se veoma rano u zivotu razvilo uverenje da smo svi ovde da bismo doprineli necim jedinstvenim, da duboko u nama lezi poseban dar.\n \n Ja zaista verujem da u svakome od nas spava DIV \n Svako od nas poseduje neki talenat, dar , vlastitit komaci genijalnosti koji ceka da bude dotaknut.\nTo moze da bude talenat za umetnost ili muziku. To moze biti specifican nacin na koji se odnosite prema onima koje volite.\nTo moze biti genijalan dar za prodaju, inovacije, ili uspeh u poslu ili karijeri.\");", ConsoleColor.Yellow);

        public static Quote AnthonyRobbins8 = new Quote("Vi ste predodredjeni za sopstveni jednistveni oblik izvrsnosti, bez obzira na to da li je to uloga izvanrednog strucnjaka, ucitelja, poslovnog coveka, majke ili oca. \n Ne samo da verujete u to , vec ste i preduzeli akciju\"", ConsoleColor.Yellow);


        
        public static void LoadAuthorsAndQuotes()
        {
            Author antony = new Author("Anthony Robbins", "Americki autor");
            Author orison = new Author("Orison Svet Marden", "Ovo dodati");
            Author dizraeli = new Author("Bendzamin Dizraeli", "Ovo dodati");


            
            antony.hisQuotes.Add(AnthonyRobbins1);
            antony.hisQuotes.Add(AnthonyRobbins2);
            antony.hisQuotes.Add(AnthonyRobbins3);
            antony.hisQuotes.Add(AnthonyRobbins4);
            antony.hisQuotes.Add(AnthonyRobbins5);
            antony.hisQuotes.Add(AnthonyRobbins6);
            antony.hisQuotes.Add(AnthonyRobbins7);
            antony.hisQuotes.Add(AnthonyRobbins8);

            orison.hisQuotes.Add(OrisonSvetMarden1);

            dizraeli.hisQuotes.Add(BendzaminDizraeli1);

            AllAuthors.Add(antony);
            AllAuthors.Add(orison);
            AllAuthors.Add(dizraeli);

        }
        
              



        public static Quote SingleQuoteWithAuthor(List<Author> allAuthors, Quote quote)
        {
            foreach (Author autor in allAuthors)
            {
                foreach (Quote oneQuote in autor.hisQuotes)
                {
                    if (autor.hisQuotes.Contains(quote))
                    {
                        if (oneQuote == quote)
                        {
                            System.Console.WriteLine($"Autor je {autor.Name}");
                        }
                        
                    }
                }
            }
            return quote;
        }


    }
}
