namespace Arrays_Hashing.LongestPalindrome;

public class LongestPalindromeProblem
{
    public int LongestPalindrome(string s)
    {
        HashSet<char> unpairedCharacters = [];
        int palindromeLength = 0;

        foreach (char character in s)
        {
            if (!unpairedCharacters.Add(character))
            {
                unpairedCharacters.Remove(character);
                palindromeLength += 2;
            }
        }

        return palindromeLength + (unpairedCharacters.Count > 0 ? 1 : 0);
    }
}