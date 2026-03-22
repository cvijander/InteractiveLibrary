using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp
{
    public class Quote
    {
       
        public string Text { get; set; }

        public ConsoleColor Color { get; set; }


        public void ShowQuote()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"\" {Text}\"");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" --------------------------------------------------------- ");
        }

        public Quote()
        {

        }

        public Quote(string text, ConsoleColor color)
        {
            Text = text;
            Color = color;
        }

    }
}
