using System;
using System.Linq;

namespace SlidingWindow.PermutationInString
{
    public static class PermutationInStringProblem
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            char[] charArray = s2.ToCharArray();
            Array.Sort(charArray);
            s2 = new string(charArray);
            int len = s1.Length;

            for (int left = 0; left + len < s2.Length; left++)
            {
                var charPart = s2.Substring(left, len).ToCharArray();
                Array.Sort(charPart);

                if (new string(charPart).Contains(s2))
                    return true;
            }

            return false;
        }
    }
}