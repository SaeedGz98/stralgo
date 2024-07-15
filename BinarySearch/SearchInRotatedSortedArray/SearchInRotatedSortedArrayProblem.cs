namespace BinarySearch.SearchInRotatedSortedArray
{
    public static class SearchInRotatedSortedArrayProblem
    {
        /// RECOMMENDED
        public static int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (nums[middle] == target)
                    return middle;

                // Check if the left half is sorted
                if (nums[left] <= nums[middle])
                {
                    // Target is in the left half
                    if (target >= nums[left] && target <= nums[middle])
                        right = middle - 1;
                    else
                        left = middle + 1;
                }
                // Right half must be sorted
                else
                {
                    // Target is in the right half
                    if (target >= nums[middle] && target <= nums[right])
                        left = middle + 1;
                    else
                        right = middle - 1;
                }
            }

            return -1;
        }
    }
}