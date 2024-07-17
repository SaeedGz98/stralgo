namespace Arrays_Hashing.ValidAnagram
{
    /// RECOMMENDED
    public static class ValidAnagramProblem
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> hashS = [], hashT = [];

            for (int i = 0; i < s.Length; i++)
            {
                hashS[s[i]] = hashS.GetValueOrDefault(s[i], 0) + 1;
                hashT[t[i]] = hashT.GetValueOrDefault(t[i], 0) + 1;
            }

            foreach (var hs in hashS)
            {
                if (hs.Value != hashT.GetValueOrDefault(hs.Key, 0))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] chartCounts = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                chartCounts[s[i] - 'a']++;
                chartCounts[t[i] - 'a']--;
            }

            return chartCounts.All(x => x == 0);
        }
    }
}