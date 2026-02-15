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

        public static int ReturnValidUserChoice(string[] listOfValidChoices)
        {
            int validatedUserReponse;
            bool isUserChoicevalid = false;
            do 
            {
                    Console.WriteLine("Input: ");
                    string? userChoice = Console.ReadLine();
                    var validationResponse = ValidationUtils.ValidMenuInput(userChoice, listOfValidChoices);
                    isUserChoicevalid = validationResponse.validResponse;
                    validatedUserReponse = validationResponse.userChoice;
            } while (isUserChoicevalid == false);

            return validatedUserReponse;
        }

        public static bool ShouldProgramKeepGoing()
        {
            bool doesUserWantToContinue = true;
            bool isUserInputYN = false;
            string? userInput = "";

            while (!isUserInputYN)
            {

                Console.WriteLine("Do you want to go back to main menu? Y/N");   
                userInput = Console.ReadLine();
                if (userInput == "Y" || userInput == "y")
                {
                    isUserInputYN = true;
                } 
                else if (userInput == "N" || userInput == "n")
                {
                    doesUserWantToContinue = false;
                    isUserInputYN = true;
                }

            } 

            return doesUserWantToContinue;
        }

                public static bool ShouldSubProgramKeepGoing()
        {
            bool doesUserWantToContinue = true;
            bool isUserInputYN = false;
            string? userInput = "";

            while (!isUserInputYN)
            {

                Console.WriteLine("Do you want to do operation again? Y/N");   
                userInput = Console.ReadLine();
                if (userInput == "Y" || userInput == "y")
                {
                    isUserInputYN = true;
                } 
                else if (userInput == "N" || userInput == "n")
                {
                    doesUserWantToContinue = false;
                    isUserInputYN = true;
                }

            } 

            return doesUserWantToContinue;
        }
    }    
}