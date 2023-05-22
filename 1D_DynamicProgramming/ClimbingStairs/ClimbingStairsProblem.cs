using System.Linq;

namespace _1D_DynamicProgramming.ClimbingStairs
{
    public static class ClimbingStairsProblem
    {
        public static int ClimbStairs(int n)
        {
            int one = 1, two = 1;

            foreach (var item in Enumerable.Range(0, n - 1))
                (one, two) = (one + two, one);

            return one;
        }
    }
}