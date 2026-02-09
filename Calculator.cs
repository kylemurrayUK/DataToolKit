
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace DataToolKitApp
{
    class Calculator
    {
        static string[] calculatorOperationChoices = ["Add", "Subtract", "Divide", "Multiply", "Return to menu"];
        static string calculatorOperationPromptMessage = "What operation would you like?";

        public static void Run()
        {
            int userOperationChoice = GetUserOperationChoice();
            RedirectToCalculatorOperationWithInputs(userOperationChoice);

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
                case 5:
                    Menu.DirectUser();
                    break;
                default:
                    Console.WriteLine("Error: Invalid input");
                    break;
            }
        }
        

        private static (double FirstNumber, double SecondNumber) GetNumbersForOperation()
        {
            string? unvalidatedFirstUserInput = "";
            string? unvalidatedSecondUserInput = "";
            double validatedFirstUserInput = 0; 
            double validatedSecondUserInput = 0;
            bool notNull = false;
            bool isDouble = false;
            
            Console.WriteLine("First Input: ");
            do
            {
                unvalidatedFirstUserInput = Console.ReadLine();
                notNull = ValidationUtils.IsInputNull(unvalidatedFirstUserInput);
                if (!notNull)
                {
                    continue;
                }

                isDouble = ValidationUtils.IsNumberDouble(unvalidatedFirstUserInput);

                if (!isDouble)
                {
                    continue;
                }
                
                validatedFirstUserInput = double.Parse(unvalidatedFirstUserInput);
            } while (!notNull || !isDouble);

            Console.WriteLine("Second Input: ");
            do
            {
                unvalidatedSecondUserInput = Console.ReadLine();
                notNull = ValidationUtils.IsInputNull(unvalidatedSecondUserInput);
                isDouble = ValidationUtils.IsNumberDouble(unvalidatedSecondUserInput);
                if (isDouble && notNull)
                {
                    validatedSecondUserInput = double.Parse(unvalidatedSecondUserInput);
                }
            } while (!notNull || !isDouble);

            return (validatedFirstUserInput, validatedSecondUserInput);
        }
        private static void Add(double firstInput, double secondInput)
        {
            double result = firstInput + secondInput;
            Console.WriteLine($"Answer: {result}");
            Run();
        }
        private static void Subract(double firstInput, double secondInput)
        {
            double result = firstInput - secondInput;
            Console.WriteLine($"Answer: {result}");
            Run();

        }
        private static void Divide(double firstInput, double secondInput)
        {
            if (firstInput == 0 || secondInput == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                (double newFirstInput, double newSecondInput) = GetNumbersForOperation();
                Divide(newFirstInput, newSecondInput);
            }
            double result = firstInput / secondInput;
            Console.WriteLine($"Answer: {result}");
            Run();
        }
        private static void Multiply(double firstInput, double secondInput)
        {
            double result = firstInput * secondInput;
            Console.WriteLine($"Answer: {result}");
            Run();
        }
    }
}