using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Lessions
{
    public static class PartFiveLessions
    {
        public static void Quotes()
        {

            foreach (Author author in BookBase.AllAuthors)
            {
                System.Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($" === Citati autora : {author.Name} === ");
                System.Console.WriteLine($"O autoru: {author.Biography}");
                System.Console.ResetColor();
                System.Console.WriteLine("------------------");

                foreach (Quote quote in author.hisQuotes)
                {
                    quote.ShowQuote();
                }
            }

            System.Console.WriteLine();

        }
    }
}
