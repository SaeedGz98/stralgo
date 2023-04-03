namespace Stack.DailyTemperatures
{
    public static class DailyTemperaturesProblem
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            int[] res = Enumerable.Repeat(0, temperatures.Length).ToArray();
            Stack<(int value, int index)> stack = new();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && stack.Peek().value < temperatures[i])
                {
                    int poppedIndex = stack.Pop().index;
                    res[poppedIndex] = i - poppedIndex;
                }
                stack.Push((temperatures[i], i));
            }

            return res;
        }
    }
}