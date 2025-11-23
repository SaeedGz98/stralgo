# 🔹 Valid Palindrome — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/valid-palindrome/

---

## 👉 Problem Summary

Given a string, determine if it's a palindrome considering only alphanumeric characters and ignoring case. A palindrome reads the same forwards and backwards. Non-alphanumeric characters (spaces, punctuation) should be ignored. The comparison is case-insensitive.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Check if string reads same forwards and backwards"**
**"Ignore certain characters" + "case-insensitive"**

Immediately trigger this thought:

🔔 **Two Pointers from opposite ends — compare inward while filtering**

**Why?** You need to verify symmetry, which means checking if `s[i] == s[n-1-i]` for all valid positions. Two pointers naturally model this by moving from both ends toward the center.

- Left pointer = start of string, moves right
- Right pointer = end of string, moves left
- Skip invalid characters at both ends before comparing

---

## 🧠 Idea → Why Two Pointers?

The palindrome property is fundamentally symmetric: the first character must match the last, the second must match the second-to-last, and so on. This naturally suggests starting from both ends and working inward.

Since we need to ignore non-alphanumeric characters, we advance each pointer past any invalid characters before comparing. This keeps the logic clean: skip, then compare, then move both pointers.

The algorithm terminates when the pointers meet or cross, meaning we've successfully verified all character pairs. If any comparison fails, we immediately return false. The case-insensitive requirement is handled by converting both characters to lowercase before comparing.

**Algorithm steps:**
1. Initialize `left = 0` and `right = s.Length - 1`
2. While `left < right`:
   - Skip non-alphanumeric characters at `left`
   - Skip non-alphanumeric characters at `right`
   - Compare `ToLower(s[left])` with `ToLower(s[right])`
   - If mismatch, return `false`
   - Move both pointers inward
3. Return `true` (all pairs matched)

---

## ✔️ C# Solution

```csharp
public static class ValidPalindromeProblem
{
    public static bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            while (!char.IsLetterOrDigit(s[left]) && left < right)
                left++;

            while (!char.IsLetterOrDigit(s[right]) && left < right)
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Guard Condition in Skip Loops

Always include `left < right` in both skip loops to prevent pointer crossover. Without this guard, you could access invalid indices if the string ends with non-alphanumeric characters.

### ✅ 2. Use Built-In Character Methods

`char.IsLetterOrDigit()` and `char.ToLower()` handle all edge cases (Unicode, digits, etc.) better than custom checks. Don't reinvent the wheel—these methods are optimized and correct.

### ✅ 3. Early Exit on Mismatch

Return `false` immediately when characters don't match. No need to continue checking once you've found a violation of the palindrome property.

### ✅ 4. Pointer Convergence Pattern

This pattern applies to many problems: pointers start at opposite ends and move toward each other until they meet. Recognize this pattern for sorted array searches, container problems, and string validation.

---

## ⏱️ Time Complexity

**Time: O(n)**

- Each pointer traverses the string at most once
- Total character inspections ≤ 2n (each character visited by at most one pointer)
- Character comparison and case conversion are O(1) operations

**Space: O(1)**

- Only two integer pointers are used
- No additional data structures scale with input size
