using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Lessions
{
    public static class PartFiveLessions
    {
        public static void Quotes()
        {

            foreach (Author author in BookBase.AllAuthors)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($" === Citati autora : {author.Name} === ");
                Console.WriteLine($"O autoru: {author.Biography}");
                Console.ResetColor();
                Console.WriteLine("------------------");

                foreach (Quote quote in author.hisQuotes)
                {
                    quote.ShowQuote();
                }
            }

            Console.WriteLine();

        }
    }
}
