namespace Greedy.JumpGameII
{
    public static class JumpGameIIProblem
    {
        public static int Jump(int[] nums)
        {
            int res = 0;
            int l = 0, r = 0;

            while (r < nums.Length - 1)
            {
                int farthest = 0;

                foreach (int i in Enumerable.Range(l, r))
                    farthest = Math.Max(farthest, i + nums[i]);

                l = r + 1;
                r = farthest;
                res++;
            }

            return res;
        }
    }
}