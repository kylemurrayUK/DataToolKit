namespace DataToolKitApp
{
class Menu()
{
    static string[] menuProgramChoices = ["Calculator", "Number Statistics", "Text Analyzer", "Exit"];
    
    public static void PrintMenu()
    {
        Console.WriteLine("What program would you like to use:");
        int i = 1;
        foreach (string menuOption in menuProgramChoices)
        {
            Console.WriteLine($"{i}.) {menuOption}");
            i++;        
        }
    }    
}
}
