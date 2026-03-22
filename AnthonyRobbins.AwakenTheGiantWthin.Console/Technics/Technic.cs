using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Technics
{
    public class Technic
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Author AuthorTechnic { get; set; }

        public List<Step> Steps { get; set; }

        public Technic(string name, string desciption, Author author)
        {
            Name = name;
            Description = desciption;
            AuthorTechnic = author;
            Steps = new List<Step>();
        }

        public void ShowTechnic()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"==== TEHNIKA : {Name} ====");
            Console.ResetColor();


            Console.WriteLine($"Author: {AuthorTechnic.Name}");
            Console.WriteLine($"Opis {Description}");
            Console.WriteLine();

            UIHelpers.GoToNextPage();


            for (int i = 0; i < Steps.Count; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Korak {i + 1} : {Steps[i].Title}");
                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine(Steps[i].Story);

                if (Steps[i].SubSteps.Count > 0)
                {
                    Console.WriteLine();
                    foreach (Step substep in Steps[i].SubSteps)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"   {substep.Title}");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine($" {substep.Story}");
                        Console.WriteLine();
                    }
                }
               

                if (i < Steps.Count -1 )
                {
                    Console.WriteLine();
                    UIHelpers.GoToNextPage();
                }
                
            }            

            Console.WriteLine("----------------------");
            Console.WriteLine("Pritisnite ENTER za povratak");
            Console.ReadLine();
        }
    }
}
