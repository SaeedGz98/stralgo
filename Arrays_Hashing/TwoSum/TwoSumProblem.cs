namespace Arrays_Hashing.TwoSum
{
    public static class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndices = [];
            int difference;

            for (int i = 0; i < nums.Length; i++)
            {
                difference = target - nums[i];

                if (numIndices.TryGetValue(difference, out int index))
                    return [index, i];
                else
                    numIndices.TryAdd(nums[i], i);
            }

            return null;
        }
    }
}