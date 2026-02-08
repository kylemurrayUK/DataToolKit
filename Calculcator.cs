namespace DataToolKitApp
{
    class Calculator
    {
        static string[] calculatorOperationChoices = ["Add", "Subtract", "Divide", "Multiply", "Return to menu"];
        static string calculatorOperationPromptMessage = "What operation would you like?";

        public static void GetUserOperationChoice()
        {
            GeneralUtils.PrintChoices(calculatorOperationChoices, calculatorOperationPromptMessage);

            int userMenuChoice = GeneralUtils.ReturnValidUserChoice(calculatorOperationChoices);
        }
    }
}