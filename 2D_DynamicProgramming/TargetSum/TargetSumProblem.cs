namespace _2D_DynamicProgramming.TargetSum
{
    public class TargetSumProblem
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            Dictionary<(int i, int total), int> dp = new();

            int backtrack(int i, int total)
            {
                if (i == nums.Length)
                    return total == target ? 1 : 0;
                if (dp.ContainsKey((i, total)))
                    return dp[(i, total)];

                dp[(i, total)] = (backtrack(i + 1, total + nums[i]) + backtrack(i + 1, total - nums[i]));

                return dp[(i, total)];
            }

            return backtrack(0, 0);
        }
    }
}