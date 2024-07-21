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

        public static IList<IList<int>> Permute2(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Backtrack(nums, 0, result);
            return result;
        }

        private static void Backtrack(int[] nums, int start, List<IList<int>> result)
        {
            if (start == nums.Length)
            {
                result.Add(new List<int>(nums));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i);
                Backtrack(nums, start + 1, result);
                Swap(nums, start, i);  // backtrack
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}