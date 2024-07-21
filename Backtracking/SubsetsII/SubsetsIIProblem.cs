using System.Collections.Generic;
using System.Linq;

namespace Backtracking.SubsetsII
{
    /// RECOMMENDED
    public static class SubsetsIIProblem
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<List<int>> res = [];
            nums = [.. nums.OrderBy(x => x)];

            void BackTrack(int i, Stack<int> subset)
            {
                if (i == nums.Length)
                {
                    res.Add([.. subset]);
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

            return [.. res];
        }
    }
}