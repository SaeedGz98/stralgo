using System;
using System.Linq;

namespace TwoPointers.ContainerWithMostWater
{
    public static class ContainerWithMostWaterProblem
    {
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            ReadOnlySpan<int> span = height.AsSpan();

            for (int i = 0; i < span.Length; i++)
            {
                int right = span.Length - 1;

                while (i < right)
                {
                    maxArea = Math.Max(maxArea, Math.Min(span[i], span[right]) * (right - i));
                    right--;
                }
            }

            return maxArea;
        }
    }
}