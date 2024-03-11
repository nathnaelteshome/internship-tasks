class PalindromeChecker{
    static bool IsPalindrome (string text){
        // Filtering text temocing non_alphapets
        string filteredText = new string(
        text.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());


        // Checking filteredText is palindrome
        for (int idx = 0; idx <  filteredText.Length / 2; idx++)
        {
            if (filteredText[idx] != filteredText[filteredText.Length - 1 - idx]){
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args) {


        string word= "rannar";
        Console.WriteLine(IsPalindrome(word));
        }
} 