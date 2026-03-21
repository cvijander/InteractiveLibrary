using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using AnthonyRobbins.AwakenTheGiantWthin.Console;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Lessions;
using AnthonyRobbins.AwakenTheGiantWthin.Console.Menus;


internal class Program
{
    private static void Main(string[] args)
    {
        BookBase.LoadAuthorsAndQuotes();       
        

        MainMenu.FrontPage();

         MainMenu.ChooseToDisplayMainMenu();
    }
                      

}




