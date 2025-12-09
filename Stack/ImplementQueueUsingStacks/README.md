# 🔹 Implement Queue using Stacks — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/implement-queue-using-stacks

---

## 👉 Problem Summary

Implement a FIFO (First In First Out) queue using only two stacks.

The queue must support `push`, `pop`, `peek`, and `empty` operations.

You must use only standard stack operations: `push to top`, `peek/pop from top`, `size`, and `is empty`.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Need to access the oldest/first element"**
**"But can only access the newest/last element (stack)"**

Immediately trigger this thought:

🔔 **Two stacks can reverse the order — pour from one to another**

**Why?** Stacks give you reverse order. Pouring from stack A → stack B reverses it again, bringing back the original order.

- First stack = temporary storage
- Second stack = reversed order (oldest now on top)

---

## 🧠 Idea → Why Two Stacks?

A single stack is LIFO. A queue is FIFO. Two stacks fix this by reversing the order twice.

**How it works:**

1. **Push**: Always add new elements to `stack1` → O(1)

2. **Pop/Peek**:
   - If `stack2` is empty, dump everything from `stack1` into `stack2`
   - This reversal puts the oldest element on top of `stack2`
   - Now pop or peek from `stack2` → returns the oldest element

3. **Empty**: Only true when both stacks are empty

**Key insight:** Elements move from `stack1` to `stack2` only when necessary. Once transferred, they stay in FIFO order until consumed.

**Example:**
```
Push(1), Push(2), Push(3)
stack1: [1, 2, 3]  (top is 3)
stack2: []

Pop() → Transfer to stack2
stack1: []
stack2: [3, 2, 1]  (top is 1) → returns 1

Push(4)
stack1: [4]
stack2: [3, 2]

Pop() → No transfer needed
stack2: [3, 2] → returns 2
```

---

## ✔️ C# Solution

```csharp
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
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Lazy Transfer = Amortized O(1)

Only transfer from `stack1` to `stack2` when `stack2` is empty.

**Why?** Each element gets moved exactly once, so over many operations, the cost averages to O(1).

### ✅ 2. Two Reversals = Original Order

Pouring water from glass A → B → C brings it back to the original arrangement.

Same principle: LIFO reversed twice becomes FIFO.

### ✅ 3. Both Stacks Empty = Queue Empty

Don't just check one stack.

`stack1` might have new elements while `stack2` is serving older ones.

### ✅ 4. This Pattern Extends Beyond Queues

Anytime you need to **transform order** between data structures, think:

**"Can I reverse it twice?"**

---

## ⏱️ Time Complexity

**Time: O(1) amortized for all operations**

- **Push**: O(1) — directly add to `stack1`
- **Pop/Peek**: O(1) amortized — each element moves from `stack1` → `stack2` at most once
- **Empty**: O(1) — check counts on both stacks

**Space: O(n)**

- Both stacks together store all `n` elements
