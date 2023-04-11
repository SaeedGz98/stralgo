using System.Linq;

namespace SlidingWindow.PermutationInString
{
    public static class PermutationInStringProblem
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] s1Count = Enumerable.Repeat(0, 26).ToArray();
            int[] s2Count = Enumerable.Repeat(0, 26).ToArray();

            for (int i = 0; i < s1.Length; i++)
            {
                s1Count[s1[i] - 'a'] += 1;
                s2Count[s2[i] - 'a'] += 1;
            }

            int matches = 0;

            for (int i = 0; i < 26; i++)
                matches += (s1Count[i] == s2Count[i]) ? 1 : 0;

            int left = 0;

            foreach (int right in Enumerable.Range(s1.Length, s2.Length - s1.Length))
            {
                if (matches == 26)
                    return true;

                int index = s2[right] - 'a';

                s2Count[index]++;

                if (s1Count[index] == s2Count[index])
                    matches++;
                else if (s2Count[index] - 1 == s1Count[index])
                    matches--;

                index = s2[left] - 'a';

                s2Count[index]--;

                if (s1Count[index] == s2Count[index])
                    matches++;
                else if (s2Count[index] + 1 == s1Count[index])
                    matches--;

                left++;
            }

            return matches == 26;
        }
    }
}