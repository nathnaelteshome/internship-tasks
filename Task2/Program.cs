class WordFrequencyAnalyzer
        {
        static Dictionary<string, int> getWordCount(string s){   

        // converting text to lowercase and split into word
        string[] words = s.ToLower().Split(new char[] {' ', '.', ',', ';', ':', '!', '?'});

        Dictionary<string, int>  wordCounts = new Dictionary<string, int>();

        // Counting Occurance in the dictionary
        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts.Add(word, 1);
            }
        }
        
        return wordCounts;
        
        }
        static void Main(string[] args) {


        string sentence= "hello friend! how are you, how.s family!";
        Dictionary<string, int> wordFrequency = getWordCount(sentence);

        foreach (KeyValuePair<string, int> entry in wordFrequency) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        }
    }
    
