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

                //left sorted
                if (nums[left] <= nums[middle])
                {
                    //search left
                    if (target >= nums[left] && target <= nums[middle])
                        right = middle - 1;
                    //search right
                    else
                        left = middle + 1;
                }
                //right sorted
                else
                {
                    //search right
                    if (target >= nums[middle] && target <= nums[right])
                        left = middle + 1;
                    //search left
                    else
                        right = middle - 1;
                }
            }

            return -1;
        }
    }
}