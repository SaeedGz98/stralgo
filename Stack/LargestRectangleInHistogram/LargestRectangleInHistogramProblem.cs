namespace Stack.LargestRectangleInHistogram
{
    public static class LargestRectangleInHistogramProblem
    {
        public static int LargestRectangleArea(int[] heights)
        {
            Stack<(int index, int height)> stack = new();
            int maxArea = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (stack.Count == 0 || stack.Peek().height <= heights[i])
                {
                    stack.Push((i, heights[i]));
                }
                else
                {
                    int fromIndex = i;
                    while (stack.Count != 0 && heights[i] < stack.Peek().height)
                    {
                        (int index, int height) popped = stack.Pop();
                        fromIndex = popped.index;
                        maxArea = Math.Max(maxArea, (i - popped.index) * popped.height);
                    }

                    stack.Push((fromIndex, heights[i]));
                }
            }

            foreach (var remainingItems in stack)
                maxArea = Math.Max(maxArea, remainingItems.height * (heights.Count() - remainingItems.index));

            return maxArea;
        }
    }
}