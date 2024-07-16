using System.Collections.Generic;

namespace SlidingWindow.SlidingWindowMaximum
{
    public class SlidingWindowMaximumProblem
    {
        /// RECOMMENDED
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0) return [];

            List<int> output = [];
            LinkedList<int> deque = new();
            int l = 0, r = 0;

            while (r < nums.Length)
            {
                // Pop smaller values from deque
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[r])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(r);

                // Remove left value from window
                if (l > deque.First.Value)
                {
                    deque.RemoveFirst();
                }

                // If window has hit size k, add to results
                if (r + 1 >= k)
                {
                    output.Add(nums[deque.First.Value]);
                    l++;
                }

                r++;
            }

            return output.ToArray();
        }
    }
}