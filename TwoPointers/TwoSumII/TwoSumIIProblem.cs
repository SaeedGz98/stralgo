namespace TwoPointers.TwoSumII
{
    public static class TwoSumIIProblem
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum < target)
                    left++;
                else if (sum > target)
                    right--;
                else
                    return new int[] { left + 1, right + 1 };
            }

            return null;
        }
    }
}