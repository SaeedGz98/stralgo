namespace Stack.GenerateParentheses
{
    public static class GenerateParenthesesProblem
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            Stack<char> stack = new();
            List<string> result = new();

            void Backtrack(int openN, int closedN)
            {
                if (openN == closedN && closedN == n)
                {
                    result.Add(string.Join(string.Empty, stack.Reverse()));
                    return;
                }

                if (openN < n)
                {
                    stack.Push('(');

                    Backtrack(openN + 1, closedN);

                    stack.Pop();
                }

                if (closedN < openN)
                {
                    stack.Push(')');

                    Backtrack(openN, closedN + 1);

                    stack.Pop();
                }
            }

            Backtrack(0, 0);

            return result;
        }
    }
}