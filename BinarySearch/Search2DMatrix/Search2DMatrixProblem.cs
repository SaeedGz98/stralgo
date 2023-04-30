namespace BinarySearch.Search2DMatrix
{
    public static class Search2DMatrixProblem
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length, cols = matrix[0].Length;

            int top = 0, bottom = rows - 1;
            int row = default;

            while (top <= bottom)
            {
                row = (top + bottom) / 2;

                if (target < matrix[row][0])
                    bottom = row - 1;
                else if (target > matrix[row][^1])
                    top = row + 1;
                else
                    break;
            }

            if (top > bottom)
                return false;

            row = (top + bottom) / 2;

            bool hasFound = BinarySearch(matrix[row], target);

            return hasFound;
        }

        private static bool BinarySearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (target > nums[middle])
                    left = middle + 1;
                else if (target < nums[middle])
                    right = middle - 1;
                else
                    return true;
            }

            return false;
        }
    }
}