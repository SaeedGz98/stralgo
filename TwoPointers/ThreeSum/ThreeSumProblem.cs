using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoPointers.ThreeSum
{
    public static class ThreeSumProblem
    {
        /// RECOMMENDED
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            ReadOnlySpan<int> span = nums.OrderBy(x => x).ToArray().AsSpan();
            List<List<int>> res = new();

            for (int i = 0; i < span.Length; i++)
            {
                if (i > 0 && span[i] == span[i - 1])
                    continue;

                int left = i + 1;
                int right = span.Length - 1;

                while (left < right)
                {
                    int sumOfThree = span[i] + span[left] + span[right];

                    if (sumOfThree > 0)
                        right--;
                    else if (sumOfThree < 0)
                        left++;
                    else
                    {
                        res.Add([span[i], span[left], span[right]]);

                        left++;

                        while (span[left] == span[left - 1] && left < right)
                            left++;
                    }
                }
            }

            return res.ToArray();
        }
    }
}