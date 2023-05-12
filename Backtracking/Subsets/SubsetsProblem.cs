using System.Collections.Generic;
using System.Linq;

namespace Backtracking.Subsets
{
    public static class SubsetsProblem
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            List<List<int>> res = new();
            Stack<int> subset = new();

            void DFS(int i)
            {
                if (i >= nums.Length)
                {
                    res.Add(subset.ToList());
                    return;
                }

                subset.Push(nums[i]);
                DFS(i + 1);

                subset.Pop();
                DFS(i + 1);
            }

            DFS(0);

            return res.ToArray();
        }
    }
}