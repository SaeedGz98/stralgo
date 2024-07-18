namespace Arrays_Hashing.GroupAnagrams
{
    /// RECOMMENDED
    public static class GroupAnagramsProblem
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = [];

            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new(chars);

                if (!dict.ContainsKey(key))
                    dict[key] = [];

                dict[key].Add(str);
            }

            return [.. dict.Values];
        }
    }
}