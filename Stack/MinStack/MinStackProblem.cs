namespace Stack.MinStack
{
    public class MinStackProblem
    {
        private Stack<int> _stack;
        private Stack<int> _minStack;

        public MinStackProblem()
        {
            _stack = new();
            _minStack = new();
        }

        public void Push(int val)
        {
            _stack.Push(val);

            if (_minStack.Count == 0 || val <= _minStack.Peek())
                _minStack.Push(val);
        }

        public void Pop()
        {
            if (_stack.Count == 0)
                return;

            int poped = _stack.Pop();

            if (_minStack.Peek() == poped)
                _minStack.Pop();
        }

        public int Top()
        {
            if (_stack.Count == 0)
                return -1;

            return _stack.Peek();
        }

        public int GetMin()
        {
            if (_minStack.Count == 0)
                return -1;

            return _minStack.Peek();
        }
    }
}