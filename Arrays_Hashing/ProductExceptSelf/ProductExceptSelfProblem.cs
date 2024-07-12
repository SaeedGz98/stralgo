namespace Arrays_Hashing.ProductExceptSelf
{
    /// RECOMMENDED
    public static class ProductExceptSelfProblem
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] res = Enumerable.Repeat(1, nums.Length).ToArray();

            int prefix = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = prefix;
                prefix *= nums[i];
            }

            int postfix = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] = res[i] * postfix;
                postfix *= nums[i];
            }

            return res;
        }
    }
}