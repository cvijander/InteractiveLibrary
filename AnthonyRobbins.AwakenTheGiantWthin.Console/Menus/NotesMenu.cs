using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus
{
    public static class NotesMenu
    {
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

        public static void ChooseToDisplayNotes()
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
                    UIHelpers.ExitProgram();
                    return false;

                default:
                    UIHelpers.ErrorMessage();
                    return true;
            }

        }

        #endregion
    }
}
