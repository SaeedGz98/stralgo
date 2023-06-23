namespace BitManipulation.SingleNumber
{
    public class SingleNumberProblem
    {
        public static int SingleNumber(int[] nums)
        {
            int res = 0;

            foreach (var num in nums)
                res = res ^ num;

            return res;
        }
    }
}
