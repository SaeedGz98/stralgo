namespace _1D_DynamicProgramming.LongestPalindromicSubstring
{
    public static class LongestPalindromicSubstringProblem
    {
        public static string LongestPalindrome(string s)
        {
            string res = "";
            int resLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int left = i, right = i;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > resLength)
                    {
                        res = s[left..(right + 1)];
                        resLength = right - left + 1;
                    }

                    left -= 1;
                    right += 1;
                }

                left = i;
                right = i + 1;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > resLength)
                    {
                        res = s[left..(right + 1)];
                        resLength = right - left + 1;
                    }

                    left -= 1;
                    right += 1;
                }
            }

            return res;
        }
    }
}