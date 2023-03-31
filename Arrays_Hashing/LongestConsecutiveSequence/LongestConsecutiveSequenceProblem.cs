namespace Arrays_Hashing.LongestConsecutiveSequence
{
    public static class LongestConsecutiveSequenceProblem
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> numSet = nums.ToHashSet<int>();
            int longest = 0;
            int length;
            int nextNum;

            foreach (int num in nums)
            {
                if (numSet.Contains(num - 1)) continue;

                length = 1;
                nextNum = num + 1;
                while (numSet.Contains(nextNum))
                {
                    length++;
                    nextNum++;
                }

                longest = Math.Max(longest, length);
            }

            return longest;
        }
    }
}