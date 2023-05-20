namespace Heap_PriorityQueue.KthLargestElementInAnArray
{
    public static class KthLargestElementInAnArrayProblem
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            //Heap solution has n+klogn time complexity because heapify the array take o(n) time
            //and each pop from heap take o(logn) and we need k pop operation
            //------------------------------------------------------------------------------------

            k = nums.Length - k;

            int QuickSelect(int l, int r)
            {
                int pivot = nums[r], p = l;

                for (int i = l; i < r; i++)
                {
                    if (nums[i] < pivot)
                    {
                        (nums[p], nums[i]) = (nums[i], nums[p]);
                        p++;
                    }
                }

                (nums[p], nums[r]) = (nums[r], nums[p]);

                if (p > k)
                    return QuickSelect(l, p - 1);
                else if (k > p)
                    return QuickSelect(p + 1, r);
                else
                    return nums[p];
            }

            return QuickSelect(0, nums.Length - 1);
        }
    }
}