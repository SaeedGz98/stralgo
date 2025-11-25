# 🔹 Valid Anagram — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/valid-anagram](https://leetcode.com/problems/valid-anagram)

---

## 👉 Problem Summary

You are given two strings `s` and `t`. Return **true** if `t` is an **anagram** of `s`, meaning both strings contain the same characters with the same frequencies.
Both strings consist of lowercase English letters, and their lengths are up to `5 * 10^4`.
If lengths differ, the answer must be false.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Check if two strings have the same characters"**
**"Same frequency for each character"**

Immediately trigger:

🔔 **Use character frequency counting (HashMap or fixed-size array)**

**Why?**
Anagrams are fundamentally frequency-matching problems. Counting occurrences and comparing them is the fastest and cleanest solution.

* Count frequency of characters in both strings
* Compare the frequency maps
* If all counts match → anagram

---

## 🧠 Idea → Why Frequency Counting?

Anagrams do not depend on character **order**, only **frequency**.
Thus, sorting is unnecessary — counting is more efficient.

### Thought process:

1. If lengths differ → cannot be anagrams.
2. Build a frequency table from string `s`.
3. Subtract counts using string `t`.
4. If all final counts return to zero → same multiset of characters → valid anagram.

### One-pass optimization:

Use a fixed-size array of length 26 for lowercase letters:

1. For each index `i`:

   * `counts[s[i]]++`
   * `counts[t[i]]--`
2. At the end, ensure all counts are zero.

---

## ✔️ C# Solutions

### **Way 1 — One Dictionary Count Up, One Count Down**

```csharp
bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    Dictionary<char, int> frequency = [];

    foreach (char ch in s)
    {
        frequency[ch] = frequency.GetValueOrDefault(ch, 0) + 1;
    }

    foreach (char ch in t)
    {
        if (frequency.TryGetValue(ch, out int count))
            frequency[ch] = --count;
        else
            return false;
    }

    return frequency.All(x => x.Value == 0);
}
```

---

### **Way 2 — Two Dictionary Frequency Tables**

```csharp
public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, int> hashS = [], hashT = [];

    for (int i = 0; i < s.Length; i++)
    {
        hashS[s[i]] = hashS.GetValueOrDefault(s[i], 0) + 1;
        hashT[t[i]] = hashT.GetValueOrDefault(t[i], 0) + 1;
    }

    foreach (var hs in hashS)
    {
        if (hs.Value != hashT.GetValueOrDefault(hs.Key, 0))
        {
            return false;
        }
    }

    return true;
}
```

---

### **Way 3 — Most Optimal: Fixed-Size Array (26 chars)**

```csharp
public bool IsAnagram(string s, string t) 
{
    if (s.Length != t.Length) return false;

    int[] chartCounts = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        chartCounts[s[i] - 'a']++;
        chartCounts[t[i] - 'a']--;
    }

    return chartCounts.All(x => x == 0);
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Always Check Length First

If lengths differ, no need for further work — instantly false.

### ✅ 2. Frequency Matching Beats Sorting

Sorting is **O(n log n)**, while counting characters is **O(n)** and simpler.

### ✅ 3. Use Fixed Array for Lowercase Letters

A `26-length int[]` is faster and more memory-efficient than a dictionary.

### ✅ 4. Count Up and Down in One Loop

Increment for `s[i]`, decrement for `t[i]` — gives a very clean O(n) solution.

---

## ⏱️ Time Complexity

**Time: O(n)**

* You iterate through each string once
* All lookups/updates (dictionary or array) are O(1)

**Space: O(1)**

* Character set is fixed (26 lowercase letters)
* Even dictionary approaches are technically O(1) due to fixed alphabet size


