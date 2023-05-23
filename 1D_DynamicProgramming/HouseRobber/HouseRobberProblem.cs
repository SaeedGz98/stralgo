using System;
using System.Linq;

namespace _1D_DynamicProgramming.HouseRobber
{
    public static class HouseRobberProblem
    {
        public static int Rob(int[] nums)
        {
            int rob1 = 0, rob2 = 0;

            foreach (var num in nums)
            {
                (rob1, rob2) = (rob2, Math.Max(num + rob1, rob2));
            };

            return rob2;
        }
    }
}