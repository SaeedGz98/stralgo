# 🔹 Climbing Stairs — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/climbing-stairs/

---

## 👉 Problem Summary

You are given an integer `n` representing the total number of steps to reach the top of a staircase.  
At each move, you can climb either **1 step or 2 steps**.  
Return the total number of **distinct ways** to reach the top.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Count the number of distinct ways"**  
**"Choices depend only on previous smaller steps"**

Immediately trigger this thought:

🔔 **Dynamic Programming (Fibonacci-style state transition)**

**Why?** The number of ways to reach step `n` depends only on the ways to reach `n-1` and `n-2`.

- Ways(n) = Ways(n - 1) + Ways(n - 2)
- Only the previous two states are ever needed

---

## 🧠 Idea → Why Dynamic Programming?

This problem exhibits **optimal substructure**:
- The solution for step `n` is built directly from solutions to smaller steps

And **overlapping subproblems**:
- The same step counts are reused multiple times

This recurrence mirrors the **Fibonacci sequence**, but instead of storing all values, we can optimize space:
1. Track only the last two results
2. Update them iteratively
3. Avoid recursion and extra memory

The key insight:  
> You don’t need the full DP array — only the previous two states matter.

---

## ✔️ C# Solution

```csharp
public static int ClimbStairs(int n)
{
    int one = 1, two = 1;

    for (int i = 0; i < n - 1; i++)
        (one, two) = (one + two, one);

    return one;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Recognize Fibonacci Patterns

When a problem says “ways to reach” with small step options, think Fibonacci-style DP.

### ✅ 2. Space Optimization Is Key

You don’t need a full DP array when only the last two states are used.

### ✅ 3. Iterative Beats Recursive

This avoids stack overhead and exponential recomputation.

### ✅ 4. Base Case Matters

Starting with `one = 1` and `two = 1` correctly models steps 0 and 1.

---

## ⏱️ Time Complexity

**Time: O(n)**

* You compute each step exactly once
* Simple linear iteration

**Space: O(1)**

* Only two integer variables are used
* No additional data structures
