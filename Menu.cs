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
                    var validationResponse = ValidateUserChoice(userChoice);
                    isUserChoicevalid = validationResponse.validResponse;
                    validatedUserReponse = validationResponse.userChoice;
                } while (isUserChoicevalid == false);


                return validatedUserReponse;

            }    

            public static (int userChoice, bool validResponse) ValidateUserChoice(string? unvalidatedUserChoice)
            {
                int userAnswer;
                bool isResponseValid;

                if (unvalidatedUserChoice == "")
                {
                    Console.WriteLine("Null is not a valid answer");
                    userAnswer = 0;
                    isResponseValid = false;
                    return (userAnswer, isResponseValid);
                }
                else if (!int.TryParse(unvalidatedUserChoice, out userAnswer))
                {
                    Console.WriteLine("Must be an integer!");
                    userAnswer = 0;
                    isResponseValid = false;
                    return (userAnswer, isResponseValid);
                }
                else if (userAnswer > menuProgramChoices.Length || userAnswer < 1)
                {
                    Console.WriteLine($"Must be between 1 and {menuProgramChoices.Length}!");
                    userAnswer = 0;
                    isResponseValid = false;
                    return (userAnswer, isResponseValid);
                }
                else
                {
                    isResponseValid = true;
                    return (userAnswer, isResponseValid);
                }

            }

            public static void RedirectUser(int userChoice)
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Calculator");
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
