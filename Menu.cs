namespace DataToolKitApp
{
    class Menu()
        {
            static string[] menuProgramChoices = ["Calculator", "Number Statistics", "Text Analyzer", "Exit"];
            static string MainMenuUserPrompt = "What program would you like to use: ";
            public static void DirectUser()
            {
                GeneralUtils.PrintChoices(menuProgramChoices, MainMenuUserPrompt);
                Menu.RedirectUser(GeneralUtils.ReturnValidUserChoice(menuProgramChoices));
            } 



            public static void RedirectUser(int userChoice)
            {
                switch (userChoice)
                {
                    case 1:
                        Calculator.Run() ;
                        break;
                    case 2:
                        Console.WriteLine("Number Statistics");
                        break;
                    case 3:
                        Console.WriteLine("Text Analyzer");
                        break;
                    case 4:
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error: Invalid input");
                        break;
                }
                
            }
        }
}
