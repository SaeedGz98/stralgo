# 🔹 Binary Search — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/binary-search](https://leetcode.com/problems/binary-search)

---

## 👉 Problem Summary

You are given a sorted integer array `nums` and a target value.
Your task is to return the **index** of the target if it exists, otherwise return **-1**.
Because the array is sorted, the required runtime must be **O(log n)**, which naturally suggests binary search.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Array is sorted"**
**"Must use O(log n)"**

Immediately trigger:

🔔 **Binary Search using two pointers (`left`, `right`)**

**Why?**
Binary search repeatedly halves the search space, making it the only algorithm that meets the required time complexity for sorted arrays.

* Check the middle element
* Decide which half must contain the target
* Narrow the search space

---

## 🧠 Idea → Why Binary Search?

Binary search is designed for **monotonic** (sorted) data.
Instead of scanning the entire array (O(n)), we eliminate half of the array each iteration.

### Step-by-step reasoning:

1. Initialize `left = 0` and `right = nums.Length - 1`.
2. Compute the midpoint.
3. If midpoint value equals target → return index.
4. If target is smaller → search the left half.
5. If target is larger → search the right half.
6. Continue until pointers cross.
7. If not found, return `-1`.

### Key insight:

Sorted data allows you to confidently remove half of the remaining search space every step.

---

## ✔️ C# Solution

```csharp
public int Search(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;

    while (left <= right)
    {
        int middle = (left + right) / 2;

        if (nums[middle] == target)
        {
            return middle;
        }
        else if (target < nums[middle])
        {
            right = middle - 1;
        }
        else if (target > nums[middle])
        {
            left = middle + 1;
        }
    }

    return -1;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Always Think “Sorted → Binary Search”

If the input is sorted, your first instinct should be binary search unless proven otherwise.

### ✅ 2. Use `left <= right` as Loop Condition

Ensures you correctly handle arrays with one element and cases where pointers converge.

### ✅ 3. Avoid Overthinking Mid Calculation Early

For interviews, `(left + right) / 2` is perfectly fine unless overflow is a concern.

### ✅ 4. Think in Terms of Eliminating Halves

Each comparison must remove half of the remaining options — this keeps the algorithm O(log n).

---

## ⏱️ Time Complexity

**Time: O(log n)**

* Each iteration halves the search space.
* Continues until the range collapses.

**Space: O(1)**

* Uses only constant extra variables (`left`, `right`, `middle`).