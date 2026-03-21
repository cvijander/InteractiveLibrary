using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.Console.Menus
{
    public static class NotesMenu
    {
        #region Part Seven Notes
        private static void DisplayNotes()
        {
            System.Console.Clear();
            System.Console.WriteLine("==== OSMI DEO: VASE BELESKE  ====");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Beleske ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("0. Povratak u glavni meni");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("99. -- Napusti program -- ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Unesite opciju: ");
        }

        private static void ChooseToDisplayNotes()
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
                DisplayNotes();
                string userInput = System.Console.ReadLine().Trim();
                displayMenu = HandleDisplayNotes(userInput);

            }
        }

        private static bool HandleDisplayNotes(string input)
        {
            switch (input)
            {
                case "1":
                    System.Console.Clear();
                    System.Console.WriteLine("Unesite vase beleske, ovde, te iste beleske videce u text fajlu nazvan \"KorisnickeBeleske.txt\"");
                    string beleske = "";
                    string userInput = System.Console.ReadLine();
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
