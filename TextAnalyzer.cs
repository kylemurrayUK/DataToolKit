namespace DataToolKitApp
{
    class TextAnalyzer
    {
        static string?  originalValidatedUserInput;

        public static void Run()
        {
            GetUserInput();
        }

        public static string? GetUserInput()
        {
            string? unvalidatedUserInput;
            bool HasValue = false;

            while (!(bool)HasValue)
            {
                Console.WriteLine("Enter string for analysis:");
                unvalidatedUserInput = Console.ReadLine();   
                HasValue = ValidationUtils.DoesStringHaveValue(unvalidatedUserInput);
                if (HasValue)
                    originalValidatedUserInput = unvalidatedUserInput;    
            }

            return unvalidatedUserInput = "";
        }
    }    
}