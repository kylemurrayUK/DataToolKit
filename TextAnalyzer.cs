namespace DataToolKitApp
{
    class TextAnalyzer
    {

        public static void Run()
        {
            Console.WriteLine(AnalyseText(GetUserInput()));
        }

        public static string? GetUserInput()
        {
            string? unvalidatedUserInput;
            string? ValidatedUserInput = "";
            bool HasValue = false;

            while (!(bool)HasValue)
            {
                Console.WriteLine("Enter string for analysis:");
                unvalidatedUserInput = Console.ReadLine();   
                HasValue = ValidationUtils.DoesStringHaveValue(unvalidatedUserInput);
                if (HasValue)
                    ValidatedUserInput = unvalidatedUserInput;    
            }

            return ValidatedUserInput;
        }

        private static string AnalyseText(string userInput)
        {
            string TextAnalysis = "";
            List<string> CleanedWords = PutInputInListAndClean(userInput);
            
            int CharacterCount = CountCharacters(CleanedWords);
            int WordCount = CountWords(CleanedWords);
            string LongestWord = FindLongestWord(CleanedWords);

            return TextAnalysis = "Text Analysis:\n" +
                            $"Character count: {CharacterCount}\n" +
                            $"Word count: {WordCount}\n" +
                            $"Longest word: {LongestWord}";
        }

        private static List<string> PutInputInListAndClean(string userInput)
        {
            List<string> Words = new List<string>();
            char[] splitValues = [' ', '.'];

            string[] splitStringArray = userInput.Split(splitValues, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            foreach (string word in splitStringArray)
            {
                Words.Add(word.ToLower());
            }

            return Words;
        }

        private static int CountCharacters(List<string> CleanedWords)
        {
            int characterCount = 0;

            foreach (string word in CleanedWords)
            {
                characterCount = characterCount + word.Length;
            }

            return characterCount;
        }

        private static int CountWords(List<string> CleanedWords)
        {
            return CleanedWords.Count;
        }

        private static string FindLongestWord(List<string> CleanedWords)
        {
            string LongestWord = "";

            foreach (string word in CleanedWords)
            {
                if (word.Length > LongestWord.Length)
                {
                    LongestWord = word;
                }
            }

            return LongestWord;
        }
    }    
}