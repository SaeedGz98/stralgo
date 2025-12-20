namespace _1D_DynamicProgramming.ClimbingStairs
{
    public static class ClimbingStairsProblem
    {
        public static int ClimbStairs(int n)
        {
            int one = 1, two = 1;

            for (int i = 0; i < n - 1; i++)
                (one, two) = (one + two, one);

            return one;
        }
    }
}