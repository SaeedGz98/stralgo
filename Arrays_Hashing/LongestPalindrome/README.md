# 🔹 Longest Palindrome — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/longest-palindrome/

---

## 👉 Problem Summary

You are given a string `s` containing lowercase and uppercase letters.  
Each character can be used **at most once per occurrence** to build a palindrome.  
Return the **maximum possible length** of a palindrome that can be formed using those letters.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Rearrange characters freely"**  
**"Maximize palindrome length using character counts"**

Immediately trigger this thought:

🔔 **Pair matching using a HashSet (or frequency parity check)**

**Why?** A palindrome is symmetric, so characters must form **pairs**, except possibly one center character.

- Even counts → fully usable  
- Odd counts → pairs + at most **one center**

---

## 🧠 Idea → Why HashSet?

A palindrome has a strict structural rule:
- Characters must appear in **pairs** (one on each side)
- Only **one unpaired character** is allowed in the center

Instead of counting exact frequencies, this solution tracks **parity (odd vs even)** using a `HashSet`:

- First occurrence → mark as unpaired
- Second occurrence → forms a pair → remove from set
- Each completed pair adds `2` to the palindrome length

At the end:
- If **any unpaired character exists**, we can place **one** in the center

The key insight:  
> We don’t need full counts — only whether a character is currently paired or unpaired.

---

## ✔️ C# Solution

```csharp
namespace Arrays_Hashing.LongestPalindrome;

public class LongestPalindromeProblem
{
    public int LongestPalindrome(string s)
    {
        HashSet<char> unpairedCharacters = [];
        int palindromeLength = 0;

        foreach (char character in s)
        {
            if (!unpairedCharacters.Add(character))
            {
                unpairedCharacters.Remove(character);
                palindromeLength += 2;
            }
        }

        return palindromeLength + (unpairedCharacters.Count > 0 ? 1 : 0);
    }
}
````

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Think in Pairs, Not Counts

Palindromes care about **evenness**, not exact frequency values.

### ✅ 2. HashSet Tracks Parity Cleanly

Add = odd count, Remove = even count — no counters needed.

### ✅ 3. Only One Center Is Allowed

No matter how many odd characters remain, only one can contribute `+1`.

### ✅ 4. Early Optimization Is Unnecessary

You must scan the entire string to know all possible pairs.

---

## ⏱️ Time Complexity

**Time: O(n)**

* Single pass through the string
* Constant-time `HashSet` operations

**Space: O(1)**

* At most 52 characters (uppercase + lowercase)
* Space does not grow with input size