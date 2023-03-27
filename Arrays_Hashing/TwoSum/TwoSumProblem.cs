namespace Arrays_Hashing.TwoSum
{
    public static class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsHash = new();
            int diff;

            for (int i = 0; i < nums.Length; i++)
            {
                diff = target - nums[i];

                if (numsHash.ContainsKey(diff))
                {
                    return new int[] { i, numsHash[diff] };
                }
                else
                {
                    if (!numsHash.ContainsKey(nums[i]))
                        numsHash.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}