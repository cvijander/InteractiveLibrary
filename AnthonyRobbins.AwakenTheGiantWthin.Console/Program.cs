using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Helpers;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Lessions;
using AnthonyRobbins.AwakenTheGiantWthin.ConsoleApp.Menus;


internal class Program
{
    private static void Main(string[] args)
    {
        BookBase.LoadAuthorsAndQuotes();       
        

        MainMenu.FrontPage();

        MainMenu.ChooseToDisplayMainMenu();
    }
                      

}




