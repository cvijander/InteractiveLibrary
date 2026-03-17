using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console
{
    public class Quote
    {
       
        public string Text { get; set; }

        public ConsoleColor Color { get; set; }


        public void ShowQuote()
        {
            System.Console.ForegroundColor = Color;
            System.Console.WriteLine($"\" {Text}\"");
            System.Console.WriteLine();
            System.Console.WriteLine($"- Author");
            System.Console.ResetColor();
            System.Console.WriteLine();
            System.Console.WriteLine(" --------------------------------------------------------- ");
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
