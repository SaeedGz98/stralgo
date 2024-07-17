namespace TwoPointers.ValidPalindrome
{
    /// RECOMMENDED
    public static class ValidPalindromeProblem
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                while (!char.IsLetterOrDigit(s[left]) && left < right)
                    left++;

                while (!char.IsLetterOrDigit(s[right]) && left < right)
                    right--;

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}