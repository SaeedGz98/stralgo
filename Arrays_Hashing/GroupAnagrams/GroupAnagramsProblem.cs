namespace Arrays_Hashing.GroupAnagrams
{
    public static class GroupAnagramsProblem
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, string[]> anagramHash = new();
            string sortedStr;
            foreach (var str in strs)
            {
                sortedStr = string.Concat(str.OrderBy(x => x));

                if (anagramHash.ContainsKey(sortedStr))
                {
                    anagramHash[sortedStr] =
                        anagramHash[sortedStr].Append(str).ToArray();
                }
                else
                {
                    anagramHash.Add(sortedStr, new string[] { str });
                }
            }

            return anagramHash.Select(x => x.Value.ToArray()).ToArray();
        }
    }
}