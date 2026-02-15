namespace DataToolKitApp
{
    class Menu
        {
            static string[] menuProgramChoices = ["Calculator","Text Analyzer", "Number Statistics", "Exit"];
            static string MainMenuUserPrompt = "What program would you like to use: ";
            public static void DirectUser()
            {
                bool shouldProgramKeepGoing = true;

                while (shouldProgramKeepGoing)
                {
                    GeneralUtils.PrintChoices(menuProgramChoices, MainMenuUserPrompt);
                    shouldProgramKeepGoing = RedirectUser(GeneralUtils.ReturnValidUserChoice(menuProgramChoices));   
                }

                return;
            } 



            public static bool RedirectUser(int userChoice)
            {
                switch (userChoice)
                {
                    case 1:
                        Calculator.Run();
                        return GeneralUtils.ShouldProgramKeepGoing();
                    case 2:
                        TextAnalyzer.Run();
                        return GeneralUtils.ShouldProgramKeepGoing();
                    case 3:
                        NumberStatistics.Run();
                        return GeneralUtils.ShouldProgramKeepGoing();
                    case 4:
                        return false;
                    default:
                        Console.WriteLine("Error: Invalid input");
                        return GeneralUtils.ShouldProgramKeepGoing();
                }
                
            }
        }
}
