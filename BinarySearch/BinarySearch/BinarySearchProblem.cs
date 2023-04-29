namespace BinarySearch.BinarySearch
{
    public static class BinarySearchProblem
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (target < nums[middle])
                {
                    right = middle - 1;
                }
                else if (target > nums[middle])
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}