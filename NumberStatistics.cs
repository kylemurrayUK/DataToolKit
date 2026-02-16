namespace DataToolKitApp
{
    class NumberStatistics
    {
        public static void Run()
        {
            Console.WriteLine(AnalyseNumbers(GetValidatedListOfNumbers()));
            return;
        }

        private static string AnalyseNumbers(List<double> userInput)
        {
            double minimum = FindMinimumNumber(userInput);
            double maximum  = FindMaximumNumber(userInput);
            double sum = FindSumOfList(userInput);
            double average = FindAverageOfList(userInput);
            

            return "Number Analysis:\n" +
                   $"Minimum Number: {minimum}\n" + 
                   $"Maximum Number: {maximum}\n" + 
                   $"Sum of Numbers: {sum}\n" +
                   $"Average of Numbers: {average}\n";  
        
        }

        private static List<double> GetValidatedListOfNumbers()
        {
            int validationChecksPassed = 0;
            string? userInput = "";
            do
            {
                validationChecksPassed = 0;
                Console.WriteLine("Input list of numbers separated by a comma (e.g. 10, 20, 30): ");
                userInput = Console.ReadLine(); 
                if (ValidationUtils.DoesStringHaveValue(userInput))
                {
                    validationChecksPassed++;
                }
                if (userInput.Split(",")[0] == userInput)
                {
                    Console.WriteLine("No commas found");
                }
                else if (!(userInput.Split(",")[0] == userInput))
                {
                    validationChecksPassed++;
                }
                if (ValidationUtils.CanEntriesInListBeConvertedToDouble(userInput.Split(",")))
                {
                    validationChecksPassed++;
                }
                else if (!ValidationUtils.CanEntriesInListBeConvertedToDouble(userInput.Split(",")))
                {
                    Console.WriteLine("An entry in list isn't a valid number");
                }


            } while (validationChecksPassed < 3);

            return ConvertValidatedListOfNumbers(userInput.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));

        }

        private static List<double> ConvertValidatedListOfNumbers(string[] entriesForList)
        {
            List<double> listOfNumbers = new();
            foreach (string entry in entriesForList)
            {
                listOfNumbers.Add(double.Parse(entry));
            }

            return listOfNumbers;
        }

        private static double FindMinimumNumber(List<double> userInput)
        {
           double minimum = userInput[0];

           foreach (double number in userInput)
            {
                if (number < minimum)
                {
                    minimum = number;
                }
            }

            return minimum;
        }
        private static double FindMaximumNumber(List<double> userInput)
        {
           double maximum = userInput[0];

           foreach (double number in userInput)
            {
                if (number > maximum)
                {
                    maximum = number;
                }
            }

            return maximum;
        }

        private static double FindSumOfList(List<double> userInput)
        {
            double sum = 0;
            foreach (double number in userInput)
            {
                sum += number;
            }

            return sum;
        }

        private static double FindAverageOfList(List<double> userInput)
        {
            return FindSumOfList(userInput) / userInput.Count;
        }
    }
}