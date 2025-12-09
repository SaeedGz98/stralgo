namespace Stack.ImplementQueueUsingStacks
{
    public class MyQueue
    {
        private readonly Stack<int> _stack1 = new();
        private readonly Stack<int> _stack2 = new();

        public MyQueue()
        {
        }

        public void Push(int x)
        {
            _stack1.Push(x);
        }

        public int Pop()
        {
            if (_stack2.Count == 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }

            return _stack2.Pop();
        }

        public int Peek()
        {
            if (_stack2.Count == 0)
            {
                while (_stack1.Count > 0)
                {
                    _stack2.Push(_stack1.Pop());
                }
            }

            return _stack2.Peek();
        }

        public bool Empty()
        {
            return Math.Max(_stack1.Count, _stack2.Count) == 0;
        }
    }
}
