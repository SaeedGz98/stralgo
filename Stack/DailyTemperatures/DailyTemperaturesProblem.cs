namespace Stack.DailyTemperatures
{
    public static class DailyTemperaturesProblem
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            int[] res = Enumerable.Repeat(0, temperatures.Length).ToArray();
            Stack<(int value, int index)> stack = new();

            foreach (int temp in temperatures)
            {
                while (stack.Count != 0 && stack.Peek)
            }
        }
    }
}