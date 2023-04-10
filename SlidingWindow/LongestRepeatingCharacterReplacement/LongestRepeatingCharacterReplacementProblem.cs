using System;
using System.Collections.Generic;
using System.Linq;

namespace SlidingWindow.LongestRepeatingCharacterReplacement
{
    public static class LongestRepeatingCharacterReplacementProblem
    {
        public static int CharacterReplacement(string s, int k)
        {
            Dictionary<char, int> count = new();
            int res = 0;
            int left = 0;
            int maxf = 0;

            for (int right = 0; right < s.Length; right++)
            {
                count[s[right]] = count.GetValueOrDefault(s[right], 0) + 1;
                maxf = Math.Max(maxf, count[s[right]]);

                while (right - left + 1 - maxf > k)
                {
                    count[s[left]] -= 1;
                    left++;
                }

                res = Math.Max(res, right - left + 1);
            }

            return res;
        }
    }
}