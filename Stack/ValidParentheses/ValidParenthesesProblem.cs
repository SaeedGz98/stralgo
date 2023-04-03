namespace Stack.ValidParentheses
{
    public static class ValidParenthesesProblem
    {
        public static bool IsValid(string s)
        {
            Stack<char> chars = new();

            foreach (var character in s)
            {
                if (!chars.Any())
                {
                    chars.Push(character);
                    continue;
                }

                if (chars.Peek() == '(' && character == ')')
                {
                    chars.Pop();
                    continue;
                }

                if (chars.Peek() == '{' && character == '}')
                {
                    chars.Pop();
                    continue;
                }

                if (chars.Peek() == '[' && character == ']')
                {
                    chars.Pop();
                    continue;
                }

                chars.Push(character);
            }

            return !chars.Any();
        }
    }
}