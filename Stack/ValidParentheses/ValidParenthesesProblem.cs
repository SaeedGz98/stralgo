namespace Stack.ValidParentheses
{
    public static class ValidParenthesesProblem
    {
        public static bool IsValid(string s)
        {
            Stack<char> chars = new();
            Dictionary<char, char> closeToOpen = new() {
                { ')','(' },
                { ']','[' },
                { '}','{' }
            };

            foreach (var character in s)
            {
                if (closeToOpen.ContainsKey(character))
                {
                    if (chars.Any() && chars.Peek() == closeToOpen[character])
                        chars.Pop();
                    else
                        return false;
                }
                else
                {
                    chars.Push(character);
                }
            }

            return !chars.Any();
        }
    }
}