# 🔹 First Bad Version — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/first-bad-version](https://leetcode.com/problems/first-bad-version)

---

## 👉 Problem Summary

You have `n` versions `[1, 2, ..., n]`. Once a version is bad, all subsequent versions are also bad. Given an API `isBadVersion(version)` that checks if a version is bad, find the first bad version while minimizing API calls.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Once condition becomes true, it stays true for all elements after"**
**"Minimize number of checks or function calls"**

Immediately trigger this thought:

🔔 **Binary Search to find the boundary (first occurrence variant)**

**Why?** The monotonic guarantee creates a sorted boundary: `[false, false, false, true, true, true]`. Binary search locates this transition point in O(log n) instead of checking every element.

- Start pointer = earliest possible answer
- End pointer = latest possible answer
- Found true? → Save it, search left for earlier occurrence
- Found false? → Search right for the boundary

---

## 🧠 Idea → Why Binary Search?

This problem has a **monotonic property**: once you hit a bad version, everything after is bad. This creates a clear boundary you can binary search on.

Linear scanning takes O(n) API calls. Binary search halves the search space each iteration, achieving O(log n) calls—optimal for minimizing expensive operations.

The key difference from standard binary search: when you find a match, **don't return immediately**. Save it as a candidate, then keep searching left to find the earliest occurrence.

### Algorithm:

1. Initialize `start = 1`, `end = n`, `firstBad = n`
2. While `start <= end`:
   - Calculate `mid = start + (end - start) / 2`
   - If `isBadVersion(mid)` is `true`:
     - Save `firstBad = mid`
     - Search left: `end = mid - 1`
   - Else:
     - Search right: `start = mid + 1`
3. Return `firstBad`

### Key insight:

This is **"find first occurrence"** binary search. Standard binary search stops at the first match. Here, you continue narrowing left to ensure you find the earliest match.

---

## ✔️ C# Solution

```csharp
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int start = 1;
        int end = n;
        int firstBad = n;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (IsBadVersion(mid))
            {
                firstBad = mid;
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return firstBad;
    }
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Recognize Monotonic Boundaries

When you hear "once true, stays true forever" or "once false, stays false forever," think binary search to find the transition point. This pattern appears in rotated sorted arrays, peak finding, and optimization problems.

### ✅ 2. Save Result, Then Narrow

Unlike exact-match binary search that returns immediately, here you save `firstBad = mid` when found, then narrow with `end = mid - 1` to find an earlier match. This ensures you get the **first** occurrence.

### ✅ 3. Prevent Overflow in Mid Calculation

Use `mid = start + (end - start) / 2` instead of `(start + end) / 2`. With `n` up to 2³¹ - 1, the sum can overflow an integer.

### ✅ 4. Handle 1-Based Indexing

Versions are numbered `[1, 2, ..., n]`, not `[0, 1, ..., n-1]`. Initialize `start = 1`, not `start = 0`. This differs from typical array problems.

---

## ⏱️ Time Complexity

**Time: O(log n)**

- Each iteration halves the search space
- Maximum log₂(n) calls to the `isBadVersion` API

**Space: O(1)**

- Uses only a constant number of variables (`start`, `end`, `mid`, `firstBad`)
- No recursion or additional data structures
