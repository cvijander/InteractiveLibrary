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
            ReadAllNotes();
            Console.WriteLine();
            Console.WriteLine("1. Unesi novu belesku ");
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
                    SaveAllNotes();
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

        private static void ReadAllNotes()
        {
            DistanceNotes();
            try
            {
                string content = File.ReadAllText(@"D:\Dev\csharp\InteractiveLibrary\AnthonyRobbins.AwakenTheGiantWthin.Console\KorisnickeBeleske.txt");
                Console.WriteLine(content);
            }

            catch (Exception ex)
            {
                CentralizedError(ex);                
            }           
            finally
            {
                DistanceNotes();
            }

        }

        private static void SaveAllNotes()
        {
            try
            {
                Console.Clear();

                ReadAllNotes();

                Console.WriteLine("Unesite vase beleske, ovde, te iste beleske videce u text fajlu nazvan \"KorisnickeBeleske.txt\"");
                Console.WriteLine("Unosom :KRAJ: prekidate izvrsavanje unosa ");
                Console.WriteLine();

               StringBuilder builder = new StringBuilder();

                bool stillWritingToNotes = true;

                //string beleske = "";

                do
                {
                    string userInput = Console.ReadLine();


                    if (userInput.Contains(":KRAJ:"))
                    {
                        stillWritingToNotes = false;

                        //beleske = beleske + "\n" + userInput.Substring(0, userInput.Length - 6);
                        builder.AppendLine(userInput.Substring(0, userInput.Length - 6));

                        break;
                    }

                    //beleske = beleske + "\n" + userInput;

                   builder.AppendLine(userInput);

                    

                } while (stillWritingToNotes);

                System.IO.File.AppendAllText(@"D:\Dev\csharp\InteractiveLibrary\AnthonyRobbins.AwakenTheGiantWthin.Console\KorisnickeBeleske.txt", builder.ToString());
            }

            catch (Exception ex)
            {
                CentralizedError(ex);
            }            

           
        }

        private static void DistanceNotes()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine();
        }

        private static void CentralizedError(Exception ex )
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            if (ex is FileNotFoundException)
            {
                
                Console.WriteLine("Nazalost, desio se problem sa aplikacijom");
                Console.WriteLine("Proverite samo da li je naziv beleski lepo napisan \"KorisnickeBeleske.txt\"");
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                
            }

            else if (ex is DirectoryNotFoundException )
            {
               
                Console.WriteLine("Nazalost, desio se problem sa aplikacijom");
                Console.WriteLine(@"Proverite samo da li direktorijum D:\\Dev\\csharp\\InteractiveLibrary\\AnthonyRobbins.AwakenTheGiantWthin.Console postoji");
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                
            }
            else
            {
                
                Console.WriteLine("Nazalost, desio se problem sa aplikacijom");
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                
            }

            Console.ResetColor();


            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine(" Pritisnite ENTER da potvrdite i da se vratite u meni ");
            Console.ReadLine();
        }

        #endregion
    }
}
