
namespace DataToolKitApp
{
    class Calculator
    {
        static string[] calculatorOperationChoices = ["Add", "Subtract", "Divide", "Multiply"];
        static string calculatorOperationPromptMessage = "What operation would you like?";
        

        public static void Run()
        {
            bool shouldProgramKeepGoing = true;
            while (shouldProgramKeepGoing)
            {
            int userOperationChoice = GetUserOperationChoice();
            RedirectToCalculatorOperationWithInputs(userOperationChoice);   
            shouldProgramKeepGoing = GeneralUtils.ShouldSubProgramKeepGoing();
            }

            return;
        }
        public static int GetUserOperationChoice()
        {
            GeneralUtils.PrintChoices(calculatorOperationChoices, calculatorOperationPromptMessage);
            return GeneralUtils.ReturnValidUserChoice(calculatorOperationChoices);
        }

        private static void RedirectToCalculatorOperationWithInputs(int userOperationChoice)
        {

            (double inputOne, double inputTwo) = GetNumbersForOperation();
            

            switch (userOperationChoice)
            {
                case 1:
                    Calculator.Add(inputOne, inputTwo);
                    break;
                case 2:
                    Calculator.Subract(inputOne, inputTwo);
                    break;
                case 3:
                    Calculator.Divide(inputOne, inputTwo);
                    break;
                case 4:
                    Calculator.Multiply(inputOne, inputTwo);
                    break;
                default:
                    Console.WriteLine("Error: Invalid input");
                    break;
            }
        }
        

        private static (double FirstNumber, double SecondNumber) GetNumbersForOperation()
        {
            double validatedFirstUserInput = 0; 
            double validatedSecondUserInput = 0;

            
            Console.WriteLine("First Input: ");
            validatedFirstUserInput = GetValidatedNumber();

            Console.WriteLine("Second Input: ");
            validatedSecondUserInput = GetValidatedNumber();

            return (validatedFirstUserInput, validatedSecondUserInput);
        }
        private static void Add(double firstInput, double secondInput)
        {
            double result = firstInput + secondInput;
            Console.WriteLine($"Answer: {result}");
            return;
        }
        private static void Subract(double firstInput, double secondInput)
        {
            double result = firstInput - secondInput;
            Console.WriteLine($"Answer: {result}");
            return;
        }
        private static void Divide(double firstInput, double secondInput)
        {
            if (secondInput == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                (double newFirstInput, double newSecondInput) = GetNumbersForOperation();
                Divide(newFirstInput, newSecondInput);
            }
            double result = firstInput / secondInput;
            Console.WriteLine($"Answer: {result}");
            return;
        }
        private static void Multiply(double firstInput, double secondInput)
        {
            double result = firstInput * secondInput;
            Console.WriteLine($"Answer: {result}");
            return;
        }

        private static double GetValidatedNumber()
        {
            string? unvalidatedUserInput;
            double validatedUserInput = 0;
            bool notNull = false;
            bool isDouble = false;

            do
            {
                unvalidatedUserInput = Console.ReadLine();
                notNull = ValidationUtils.DoesStringHaveValue(unvalidatedUserInput);
                if (!notNull)
                {
                    continue;
                }

                isDouble = ValidationUtils.IsNumberDouble(unvalidatedUserInput);

                if (!isDouble)
                {
                    continue;
                }
                validatedUserInput = double.Parse(unvalidatedUserInput);


            } while (!notNull || !isDouble);

            return validatedUserInput;
        }
    }
}