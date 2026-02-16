namespace DataToolKitApp
{
    class TextAnalyzer
    {

        public static void Run()
        {
            Console.WriteLine(AnalyseText(GeneralUtils.GetUserNotNullStringInput()));
            return;
        }


        private static string AnalyseText(string userInput)
        {
            List<string> CleanedWords = PutInputInListAndClean(userInput);
            
            int characterCount = CountCharacters(userInput);
            int wordCount = CountWords(CleanedWords);
            string longestWord = FindLongestWord(CleanedWords);
            string mostCommondWord = FindMostCommonWord(CleanedWords);

            return "Text Analysis:\n" +
                    $"Character count: {characterCount}\n" +
                    $"Word count: {wordCount}\n" +
                    $"Longest word: {longestWord}\n" +
                    $"Most Commond Word: {mostCommondWord}";
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

        private static int CountCharacters(string userInput)
        {      
            return userInput.Length;
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
        
        private static string FindMostCommonWord(List<string> CleanedWords)
        {
            Dictionary<string, int> WordsDict = OrganiseWordListIntoDictionary(CleanedWords);

            string mostCommondWord = FindKeyWithHighestValue(WordsDict);

            return mostCommondWord;
        }  

        private static Dictionary<string, int> OrganiseWordListIntoDictionary(List<string> CleanedWords)
        {
            Dictionary<string, int> WordsDict = new();
            
            foreach (string word in CleanedWords)
            {
                if (WordsDict.ContainsKey(word))
                {
                    WordsDict[word] += 1;
                }    
                else
                {
                    WordsDict.Add(word, 1);
                }
            }

            return WordsDict;
        }

        private static string FindKeyWithHighestValue(Dictionary<string, int> WordsDict)
        {
            KeyValuePair<string, int> keyWithHighestValue = new KeyValuePair<string, int>("Empty string", 0);

            foreach (KeyValuePair<string, int> dictEntry in WordsDict)
            {
                if (dictEntry.Value > keyWithHighestValue.Value)
                {
                    keyWithHighestValue = dictEntry;
                }
            } 

            if (keyWithHighestValue.Value == 1)
            {
                return "All words only occur onnce";
            }
            else
            {
                return keyWithHighestValue.Key;
            }
        }
    }

}