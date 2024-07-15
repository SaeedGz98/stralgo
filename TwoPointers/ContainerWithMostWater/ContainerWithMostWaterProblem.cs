using System;

namespace TwoPointers.ContainerWithMostWater
{
    /// RECOMMENDED
    public static class ContainerWithMostWaterProblem
    {
        public static int MaxArea(int[] height)
        {
            int maxArea = default;
            int leftHeight;
            int rightHeight;

            int left = 0, right = height.Length - 1;

            while (left != right)
            {
                leftHeight = height[left];
                rightHeight = height[right];

                maxArea = Math.Max(maxArea, Math.Min(leftHeight, rightHeight) * (right - left));

                if (leftHeight < rightHeight)
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }
}