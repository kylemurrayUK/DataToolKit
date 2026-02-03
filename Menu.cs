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

            public static void GetUserChoice()
            {
                string? userChoice = Console.ReadLine();
                
                if (userChoice == null)
                {

                }


                Console.WriteLine(userChoice);

            }    

            public static (int userChoice, bool validResponse) ValidateUserChoice(string unvalidatedUserChoice)
            {
                int userAnswer;
                bool isResponseValid;

                if (unvalidatedUserChoice == null)
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
        }
}
