using System.Collections.Generic;
using System.Linq;

namespace Backtracking.SubsetsII
{
    public static class SubsetsIIProblem
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<List<int>> res = new();
            nums = nums.OrderBy(x => x).ToArray();

            void BackTrack(int i, Stack<int> subset)
            {
                if (i == nums.Length)
                {
                    res.Add(subset.ToList());
                    return;
                }

                //All subsets that include nums[i]
                subset.Push(nums[i]);
                BackTrack(i + 1, subset);
                subset.Pop();

                //All subsets that don't include nums[i]
                while (i + 1 < nums.Length && nums[i] == nums[i + 1])
                    i += 1;

                BackTrack(i + 1, subset);
            }

            BackTrack(0, new());

            return res.ToArray();
        }
    }
}