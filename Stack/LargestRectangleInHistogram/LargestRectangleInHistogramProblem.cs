namespace Stack.LargestRectangleInHistogram
{
    public static class LargestRectangleInHistogramProblem
    {
        public static int LargestRectangleArea(int[] heights)
        {
            Stack<(int index, int height)> stack = new();
            int largestArea = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (stack.Count == 0 || stack.Peek().height <= heights[i])
                {
                    stack.Push((i, heights[i]));
                }
                else
                {


                }
            }
        }
    }
}