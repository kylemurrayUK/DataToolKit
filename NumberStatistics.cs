namespace DataToolKitApp
{
    class NumberStatistics
    {
        public static void Run()
        {
            AnalyseNumbers(GetValidatedListOfNumbers());
            return;
        }

        private static string AnalyseNumbers(List<double> userInput)
        {
            foreach (double entry in userInput)
            {
                Console.WriteLine(entry);                
            }

            return "userInput";
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
    }
}