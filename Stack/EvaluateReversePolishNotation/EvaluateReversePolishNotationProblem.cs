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

                int secondNum = stack.Pop();
                int firstNum = stack.Pop();

                int result = token[0] switch
                {
                    '+' => firstNum + secondNum,
                    '-' => firstNum - secondNum,
                    '*' => firstNum * secondNum,
                    '/' => firstNum / secondNum
                };

                stack.Push(result);
            }

            return stack.Pop();
        }
    }
}