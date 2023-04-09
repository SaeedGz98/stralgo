using System;
using System.Collections.Generic;

namespace SlidingWindow.LongestSubstringWithoutRepeatingCharacters
{
    public static class LongestSubstringWithoutRepeatingCharactersProblem
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new();
            int left = 0;
            int maxSize = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                maxSize = Math.Max(maxSize, right - left + 1);
            }

            return maxSize;
        }
    }
}