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
            Stack<int> subset = [];

            void DFS(int i)
            {
                if (i >= nums.Length)
                {
                    res.Add([.. subset]);
                    return;
                }

                subset.Push(nums[i]);
                DFS(i + 1);

                subset.Pop();
                DFS(i + 1);
            }

            DFS(0);

            return [.. res];
        }
    }
}