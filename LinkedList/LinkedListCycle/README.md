# 🔹 Linked List Cycle — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/linked-list-cycle/](https://leetcode.com/problems/linked-list-cycle/)

---

## 👉 Problem Summary

Given the `head` of a linked list, determine if the list has a cycle in it. A cycle exists if a node can be reached again by continuously following the `next` pointer. Return `true` if there is a cycle, otherwise return `false`.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Detect cycle in linked list"**
**"A node can be reached again"**

Immediately trigger **two possible approaches**:

### 🔔 Approach 1: HashSet for Visited Nodes

**Why?** If we've seen a node before, there's a cycle. Track all visited nodes in a `HashSet<ListNode>`.

- Traverse the list node by node
- Try to add each node to the HashSet
- If `Add()` returns `false`, we've seen this node before → cycle detected

### 🔔 Approach 2: Floyd's Cycle Detection (Fast & Slow Pointers)

**Why?** If there's a cycle, a fast pointer (moving 2 steps) will eventually catch up to a slow pointer (moving 1 step).

- Slow pointer = moves 1 step at a time
- Fast pointer = moves 2 steps at a time
- If they meet, cycle exists
- **Trade-off:** O(1) space instead of O(n)

---

## 🧠 Idea → Why These Two Approaches?

### Approach 1: HashSet — The Intuitive Path

This is the **most straightforward solution** and often the best starting point in an interview.

**Thought process:**
1. "Have I seen this node before?" → Use a `HashSet` for O(1) lookup
2. Traverse the linked list, adding each node to the set
3. If `Add()` returns `false`, it means the node was already in the set → cycle found
4. If we reach `null`, there's no cycle

**Pseudocode:**
```
1. Create empty HashSet
2. While current node is not null:
   - Try to add current node to HashSet
   - If add fails (already exists) → return true (cycle detected)
   - Move to next node
3. Return false (no cycle)
```

**When to use:** When space isn't a constraint, or when you want to code quickly and clearly in an interview.

---

### Approach 2: Floyd's Cycle Detection — The Optimal Solution

This is the **space-optimized solution** that interviewers love to see as a follow-up.

**Thought process:**
1. Imagine two runners on a circular track: one runs twice as fast
2. If the track is circular, the fast runner will **lap** the slow runner
3. If the track has an end, the fast runner simply reaches it first

**Why does this work mathematically?**
- In each iteration, the fast pointer gains 1 step on the slow pointer
- If they're in a cycle, the distance between them decreases by 1 each time
- Eventually, the distance becomes 0 → they meet

**Pseudocode:**
```
1. Initialize slow = head, fast = head
2. While fast and fast.next are not null:
   - Move slow 1 step forward
   - Move fast 2 steps forward
   - If slow == fast → return true (they met in the cycle)
3. Return false (fast reached the end, no cycle)
```

**When to use:** When the interviewer asks "Can you optimize space?" or when you want to show you know classic algorithms.

---

## ✔️ C# Solution

### Approach 1: HashSet Tracking

```csharp
public bool HasCycle(ListNode head)
{
    HashSet<ListNode> visited = new();
    bool hasCycle = false;

    while (!hasCycle && head != null)
    {
        hasCycle = !visited.Add(head);
        head = head.next;
    }

    return hasCycle;
}
```

**Time:** O(n) | **Space:** O(n)

---

### Approach 2: Floyd's Cycle Detection (Optimal)

```csharp
public bool HasCycle2(ListNode head)
{
    if (head == null)
        return false;

    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
            return true;
    }

    return false;
}
```

**Time:** O(n) | **Space:** O(1)

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Start with HashSet in Interviews

In a real interview, mention both approaches but **start coding the HashSet solution first**. It's clearer, easier to explain, and shows you can solve the problem. Then offer: "Would you like me to optimize the space complexity?"

### ✅ 2. Floyd's Algorithm Requires Two Null Checks

When using fast and slow pointers, always check `fast != null && fast.next != null` before moving. If you only check `fast != null`, you'll get a null reference error on `fast.next.next`.

### ✅ 3. HashSet Stores References, Not Values

The `HashSet<ListNode>` works because it compares **object references**, not the `val` field. Two nodes with the same value but different references are considered different.

### ✅ 4. Both Approaches Have O(n) Time

Don't be fooled: Floyd's algorithm doesn't improve time complexity, only space. Both solutions visit each node at most once (or a few times in the cycle case), resulting in O(n) time.

---

## ⏱️ Time Complexity

### Approach 1: HashSet

**Time: O(n)**

- We traverse the list once, visiting each node
- `HashSet.Add()` is O(1) on average

**Space: O(n)**

- In the worst case (no cycle), we store all n nodes in the HashSet

### Approach 2: Floyd's Cycle Detection

**Time: O(n)**

- If no cycle: fast pointer reaches the end after visiting n/2 nodes
- If there's a cycle: once both pointers enter the cycle, they meet within one loop around it

**Space: O(1)**

- Only two pointer variables, regardless of list size
