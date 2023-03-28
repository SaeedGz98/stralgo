namespace Arrays_Hashing.TopKFrequentElements
{
    public static class TopKFrequentElementsProblem
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new();
            List<int>[] freq = new List<int>[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
            }

            foreach (var repeat in dict)
            {
                if (freq[repeat.Value] != null)
                    freq[repeat.Value].Add(repeat.Key);
                else
                    freq[repeat.Value] = new List<int> { repeat.Key };
            }

            List<int> result = new();

            for (int i = nums.Length; i > 0; i--)
            {
                if (freq[i] == null)
                    continue;

                foreach (int num in freq[i])
                {
                    result.Add(num);

                    if (result.Count == k)
                        return result.ToArray();
                }
            }

            return null;
        }
    }
}