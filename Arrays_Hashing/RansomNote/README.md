# 🔹 Ransom Note — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/ransom-note/

---

## 👉 Problem Summary

You are given two strings: `ransomNote` and `magazine`.  
Determine whether `ransomNote` can be constructed using characters from `magazine`, where each character in `magazine` can be used **at most once**.  
Return `true` if possible, otherwise return `false`.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Each character can be used only once"**  
**"Check if enough resources exist to build something"**

Immediately trigger this thought:

🔔 **Frequency counting with a HashMap (Dictionary<char, int>)**

**Why?** You must track availability and consumption of characters efficiently with constant-time lookups.

- Magazine = available resources  
- Ransom note = required resources  

---

## 🧠 Idea → Why HashMap?

This problem is fundamentally about **resource management**.  
Each character in `magazine` represents a limited resource that can be consumed only once.

A `HashMap` (or `Dictionary` in C#) fits naturally because:
- It allows **O(1)** access to character counts
- It models availability vs. consumption cleanly
- It scales well even when strings grow large

The approach is straightforward:
1. Count how many times each character appears in `magazine`
2. Iterate through `ransomNote`
3. For each character, check if it exists and still has remaining count
4. Consume one unit; fail immediately if unavailable

The key insight:  
> If at any point a required character is missing or exhausted, construction is impossible.

---

## ✔️ C# Solution

```csharp
public static bool CanConstruct(string ransomNote, string magazine)
{
    Dictionary<char, int> magazineResource = [];

    for (int i = 0; i < magazine.Length; i++)
        magazineResource[magazine[i]] =
            magazineResource.GetValueOrDefault(magazine[i], 0) + 1;

    for (int i = 0; i < ransomNote.Length; i++)
    {
        if (magazineResource.TryGetValue(ransomNote[i], out int count) && count > 0)
            magazineResource[ransomNote[i]] = --count;
        else
            return false;
    }

    return true;
}
````

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Think in Resources

Treat `magazine` as a supply pool and `ransomNote` as demand — this mindset generalizes to many problems.

### ✅ 2. Early Exit Saves Time

Return `false` immediately when a character is missing or exhausted to avoid unnecessary work.

### ✅ 3. Dictionary Beats Nested Loops

Avoid repeated scanning of strings; frequency maps turn O(n²) ideas into O(n).

### ✅ 4. GetValueOrDefault Is Cleaner

It simplifies frequency counting and avoids extra `ContainsKey` checks.

---

## ⏱️ Time Complexity

**Time: O(n + m)**

* One pass to count characters in `magazine`
* One pass to validate and consume characters in `ransomNote`

**Space: O(1)**

* At most 26 entries for lowercase English letters
* Constant extra space regardless of input size
