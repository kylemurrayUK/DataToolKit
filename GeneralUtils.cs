namespace DataToolKitApp
{
    class GeneralUtils
    {
        public static void PrintChoices(string[] menuChoices, string promptMessage)
        {
            Console.WriteLine(promptMessage);
            int i = 1;
            foreach (string menuOption in menuChoices)
                {
                    Console.WriteLine($"{i}.) {menuOption}");
                    i++;        
                }
        }
    }    
}