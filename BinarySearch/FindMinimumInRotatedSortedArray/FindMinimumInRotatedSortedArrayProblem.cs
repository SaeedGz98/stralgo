namespace BinarySearch.FindMinimumInRotatedSortedArray
{
    public static class FindMinimumInRotatedSortedArrayProblem
    {
        public static int FindMin(int[] nums)
        {
            int res = nums[0];

            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] < nums[right])
                {
                    res = Math.Min(res, nums[left]);
                    break;
                }

                int middle = (left + right) / 2;
                res = Math.Min(res, nums[middle]);

                if (nums[middle] >= nums[left])
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return res;
        }
    }
}