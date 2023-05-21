using System.Collections.Generic;

namespace Heap_PriorityQueue.FindMedianFromDataStream
{
    public class MedianFinder
    {
        private PriorityQueue<int, int> _small;
        private PriorityQueue<int, int> _large;

        public MedianFinder()
        {
            _small = new(Comparer<int>.Create((x, y) => y - x));
            _large = new();
        }

        public void AddNum(int num)
        {
            _small.Enqueue(num, num);

            if (_small.Count > 0 && _large.Count > 0 && _small.Peek() > _large.Peek())
            {
                int val = _small.Dequeue();
                _large.Enqueue(val, val);
            }

            if (_small.Count > _large.Count + 1)
            {
                int val = _small.Dequeue();
                _large.Enqueue(val, val);
            }

            if (_large.Count > _small.Count + 1)
            {
                int val = _large.Dequeue();
                _small.Enqueue(val, val);
            }
        }

        public double FindMedian()
        {
            if (_small.Count > _large.Count)
                return _small.Peek();
            else if (_large.Count > _small.Count)
                return _large.Peek();
            else
                return (double)((decimal)(_small.Peek() + _large.Peek()) / 2);
        }
    }
}