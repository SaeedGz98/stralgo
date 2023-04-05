using System;

namespace TwoPointers.TwoSumII
{
    public static class TwoSumIIProblem
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            ReadOnlySpan<int> span = numbers.AsSpan();
            int left = 0, right = span.Length - 1;

            while (left < right)
            {
                int sum = span[left] + span[right];

                if (sum < target)
                    left++;
                else if (sum > target)
                    right--;
                else
                    return new int[] { left + 1, right + 1 };
            }

            return null;
        }
    }
}