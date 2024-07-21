using System.Collections.Generic;

namespace Backtracking.Subsets
{
    /// <summary>
    /// RECOMMENDED
    /// </summary>
    public static class SubsetsProblem
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            List<List<int>> res = [];

            void DFS(int i, Stack<int> subset)
            {
                if (i >= nums.Length)
                {
                    res.Add([.. subset]);
                    return;
                }

                subset.Push(nums[i]);
                DFS(i + 1, subset);

                subset.Pop();
                DFS(i + 1, subset);
            }

            DFS(0, []);

            return [.. res];
        }
    }
}