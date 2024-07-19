using System.Collections.Generic;

namespace Backtracking.Combinations
{
    /// RECOMMENDED
    public static class CombinationsProblem
    {
        public static IList<IList<int>> Combine(int n, int k)
        {
            List<List<int>> result = [];

            void Backtrack(int start, List<int> comb)
            {
                if (comb.Count == k)
                {
                    result.Add([.. comb]);
                    return;
                }

                for (int i = start; i < n + 1; i++)
                {
                    comb.Add(i);
                    Backtrack(i + 1, comb);
                    comb.RemoveAt(comb.Count - 1);
                }
            }

            Backtrack(1, []);

            return [.. result];
        }
    }
}