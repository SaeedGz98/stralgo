namespace Stack.EvaluateReversePolishNotation
{
    public static class EvaluateReversePolishNotationProblem
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new();

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int num))
                {
                    stack.Push(num);
                    continue;
                }

                int result = default;

                if (token[0] == '+')
                {
                    result = stack.Pop() + stack.Pop();
                }
                else if (token[0] == '-')
                {
                    int secondNum = stack.Pop();
                    int firstNum = stack.Pop();
                    result = firstNum - secondNum;
                }
                else if (token[0] == '*')
                {
                    result = stack.Pop() * stack.Pop();
                }
                else if (token[0] == '/')
                {
                    int secondNum = stack.Pop();
                    int firstNum = stack.Pop();
                    result = firstNum / secondNum;
                }

                stack.Push(result);
            }

            return stack.Pop();
        }
    }
}