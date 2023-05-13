using System.Collections.Generic;
using System.Linq;

namespace Backtracking.CombinationSum
{
    public static class CombinationSumProblem
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<List<int>> res = new();

            void DFS(int i, Stack<int> cur, int total)
            {
                if (total == target)
                {
                    res.Add(cur.ToList());
                    return;
                }

                if (i >= candidates.Length || total > target)
                    return;

                cur.Push(candidates[i]);
                DFS(i, cur, total + candidates[i]);
                cur.Pop();
                DFS(i + 1, cur, total);
            }

            DFS(0, new(), 0);

            return res.ToArray();
        }
    }
}