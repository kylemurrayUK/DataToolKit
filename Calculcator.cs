namespace DataToolKitApp
{
    class Calculator
    {
        static string[] calculatorOperationChoices = ["Add", "Subtract", "Divide", "Multiply"];
        static string calculatorOperationPromptMessage = "What operation would you like?";

        public static void GetUserOperationChoice()
        {
            GeneralUtils.PrintChoices(calculatorOperationChoices, calculatorOperationPromptMessage);
        }
    }
}