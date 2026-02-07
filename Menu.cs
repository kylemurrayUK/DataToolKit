namespace DataToolKitApp
{
    class Menu()
        {
            static string[] menuProgramChoices = ["Calculator", "Number Statistics", "Text Analyzer", "Exit"];

            public static void DirectUser()
            {
                Menu.PrintMenu();
                Menu.RedirectUser(Menu.GetUserChoice());
            } 

    
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

            public static int GetUserChoice()
            {
                int validatedUserReponse;
                bool isUserChoicevalid = false;
                
                do 
                {
                    Console.WriteLine("Input: ");
                    string? userChoice = Console.ReadLine();
                    var validationResponse = ValidationUtils.ValidMenuInput(userChoice, menuProgramChoices);
                    isUserChoicevalid = validationResponse.validResponse;
                    validatedUserReponse = validationResponse.userChoice;
                } while (isUserChoicevalid == false);


                return validatedUserReponse;

            }    

            public static void RedirectUser(int userChoice)
            {
                switch (userChoice)
                {
                    case 1:
                        Calculator.GetUserOperationChoice() ;
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
