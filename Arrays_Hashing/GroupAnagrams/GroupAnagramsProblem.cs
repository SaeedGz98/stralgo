namespace Arrays_Hashing.GroupAnagrams
{
    public static class GroupAnagramsProblem
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new();

            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }

            IList<IList<string>> result = new List<IList<string>>();
            foreach (List<string> list in dict.Values)
            {
                result.Add(list);
            }

            return result;
        }
    }
}