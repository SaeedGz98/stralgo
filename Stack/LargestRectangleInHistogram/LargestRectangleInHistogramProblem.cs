namespace Stack.LargestRectangleInHistogram
{
    public static class LargestRectangleInHistogramProblem
    {
        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            int count = heights.Length;
            Stack<(int index, int height)> stack = new(count);

            for (int i = 0; i < count; i++)
            {
                int start = i;

                while (stack.Count != 0 && heights[i] < stack.Peek().height)
                {
                    (int index, int height) popped = stack.Pop();
                    start = popped.index;
                    maxArea = Math.Max(maxArea, (i - popped.index) * popped.height);
                }

                stack.Push((start, heights[i]));
            }

            foreach (var remainingItems in stack)
                maxArea = Math.Max(maxArea, remainingItems.height * (count - remainingItems.index));

            return maxArea;
        }
    }
}