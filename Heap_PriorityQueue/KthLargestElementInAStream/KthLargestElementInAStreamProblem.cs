using System.Collections.Generic;

namespace Heap_PriorityQueue.KthLargestElementInAStream
{
    public class KthLargest
    {
        private readonly PriorityQueue<int, int> _heap = new();
        private readonly int _k;

        public KthLargest(int k, int[] nums)
        {
            _k = k;
            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            _heap.Enqueue(val, val);

            if (_heap.Count > _k)
                _heap.Dequeue();

            return _heap.Peek();
        }
    }
}