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
    }    
}