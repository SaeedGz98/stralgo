using System.Collections.Generic;
using System.Linq;

namespace Backtracking.Permutations
{
    public record class PermutationsProblem
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            List<List<int>> result = new();

            if (nums.Length == 1)
                return new List<List<int>>() { nums.ToList() }.ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[0];
                nums = nums[1..];

                IList<IList<int>> perms = Permute(nums);

                foreach (var perm in perms)
                    perm.Add(n);

                result.AddRange(perms.Select(x => x.ToList()));
                nums = nums.Append(n).ToArray();
            }

            return result.ToArray();
        }
    }
}