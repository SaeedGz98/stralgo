namespace Stack.ValidParentheses
{
    public class ValidParenthesesProblem
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> openToClose = new()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> opens = new();

            foreach (char current in s)
            {
                if (openToClose.ContainsKey(current))
                {
                    opens.Push(current);
                }
                else
                {
                    if (opens.Count == 0)
                        return false;

                    char lastOpen = opens.Pop();

                    if (openToClose[lastOpen] != current)
                        return false;
                }
            }

            return opens.Count == 0;
        }
    }
}