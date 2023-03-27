using System.Linq;

namespace Arrays_Hashing.ValidAnagram
{
    public static class ValidAnagramProblem
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> hashS = new(), hashT = new();

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
    }
}