namespace Greedy.PartitionLabels
{
    public static class PartitionLabelsProblem
    {
        public static IList<int> PartitionLabels(string s)
        {
            Dictionary<char, int> lastIndex = new();

            for (int i = 0; i < s.Length; i++)
                lastIndex[s[i]] = i;

            List<int> res = new();
            int size = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                size++;

                end = Math.Max(end, lastIndex[s[i]]);

                if (end == i)
                {
                    res.Add(size);
                    size = 0;
                }
            }

            return res;
        }
    }
}