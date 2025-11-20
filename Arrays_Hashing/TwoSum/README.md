# 🔹 Two Sum — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/two-sum

## 👉 Problem Summary

Find two different indices `i` and `j` such that:

```
nums[i] + nums[j] = target
```

Exactly one answer is guaranteed.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Find two numbers that add up to X"**

Immediately trigger this thought:

🔔 **Use complements → `target - x`**

This tells you exactly what value you're looking for.

---

## 🧠 Idea → Why HashMap?

As you scan the array, store each number in a hashmap for O(1) lookups.

For each number:

```
remaining = target - nums[i]
```

If `remaining` exists in the hashmap → you found the pair.

---

## ✔️ C# Solution

```csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int remaining = target - nums[i];

            if (dict.TryGetValue(remaining, out int value))
                return new int[] { value, i };

            dict.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Think Complement First

Always ask:

**"What number must pair with this to reach the target?"**

This instantly points to the hashmap solution.

### ✅ 2. Use HashMap for Fast Existence Checks

Hashmaps allow constant-time lookups, perfect for checking if the needed number was seen before.

### ✅ 3. Check Before You Insert

Ensures you don't reuse the same index and correctly handles duplicates.

### ✅ 4. Use the Constraints

Knowing one solution exists means:

- no need for sorting
- no backtracking
- no brute force

Streamlines the logic.

---

## ⏱️ Time Complexity

**Time: O(n)**

- We scan the list once.
- Each hashmap lookup and insertion is O(1) on average.
- So total work = proportional to the size of the array.

**Space: O(n)**

- We may store up to n elements in the hashmap.
