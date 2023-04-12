using System.Collections.Generic;

namespace SlidingWindow.MinimumWindowSubstring
{
    public static class MinimumWindowSubstringProblem
    {
        public static string MinWindow(string s, string t)
        {
            if (t == string.Empty || t.Length > s.Length)
                return string.Empty;

            Dictionary<char, int> countT = new();
            Dictionary<char, int> window = new();

            for (int i = 0; i < t.Length; i++)
                countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;

            int have = 0, need = countT.Count;
            (int left, int right) res = (-1, -1);
            int resLen = int.MaxValue;

            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right];
                window[c] = window.GetValueOrDefault(c, 0) + 1;

                if (countT.ContainsKey(c) && window[c] == countT[c])
                    have++;

                while (have == need)
                {
                    if (right - left + 1 < resLen)
                    {
                        res = (left, right);
                        resLen = right - left + 1;
                    }

                    window[s[left]]--;

                    if (countT.ContainsKey(s[left]) && window[s[left]] < countT[s[left]])
                        have--;

                    left++;
                }
            }

            return resLen != int.MaxValue ? s[res.left..(res.right + 1)] : string.Empty;
        }
    }
}