# 🔹 Majority Element — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/majority-element/

---

## 👉 Problem Summary

You are given an integer array `nums` of size `n`.  
The **majority element** is the element that appears **more than ⌊n / 2⌋ times**, and it is guaranteed to exist.  
Return the majority element.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"An element appears more than half of the time"**  
**"Majority is guaranteed to exist"**

Immediately trigger this thought:

🔔 **Boyer–Moore Majority Vote Algorithm (or frequency counting as baseline)**

**Why?** If one element appears more than all others combined, it cannot be fully canceled out.

- Majority count > n / 2  
- All other elements together < n / 2  

---

## 🧠 Idea → Why These Techniques?

### 1️⃣ HashMap (Frequency Counting — Baseline)

This is the **most straightforward** way to solve the problem.

- Count how many times each number appears
- Track the element with the highest frequency
- Since a majority is guaranteed, the max-frequency element is the answer

This approach is easy to reason about and great as a **first-pass interview solution**.

Key insight:  
> If you can count frequencies, the largest one wins.

---

### 2️⃣ Boyer–Moore (Optimal & Interview-Favorite)

This algorithm uses a **cancellation principle**.

Think of it this way:
- Every time you see the same number as the candidate → +1 vote
- Every time you see a different number → -1 vote
- When votes drop to zero, pick a new candidate

Because the majority element appears **more than half the time**, it will:
- Survive all cancellations
- End up as the final candidate

Key insight:  
> A true majority cannot be canceled out by all other elements combined.

This works in **O(n) time and O(1) space**, which directly answers the follow-up question.

---

## ✔️ C# Solution

### 🔹 HashMap Solution (Frequency Counting)

```csharp
public int MajorityElement(int[] nums)
{
    Dictionary<int, int> frequencyMap = new();
    int majorityElement = 0;
    int highestFrequency = 0;

    foreach (int number in nums)
    {
        int currentFrequency = frequencyMap.GetValueOrDefault(number) + 1;
        frequencyMap[number] = currentFrequency;

        if (currentFrequency > highestFrequency)
        {
            highestFrequency = currentFrequency;
            majorityElement = number;
        }
    }

    return majorityElement;
}
````

---

### 🔹 Boyer–Moore Majority Vote (Optimal)

```csharp
public int MajorityElement_BoyerMoore(int[] nums)
{
    int candidate = 0;
    int voteCount = 0;

    foreach (int number in nums)
    {
        if (voteCount == 0)
            candidate = number;

        voteCount += (number == candidate) ? 1 : -1;
    }

    return candidate;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Majority Guarantee Is Critical

Boyer–Moore works **only because** the majority element is guaranteed to exist.

### ✅ 2. Think in Cancellation

If elements cancel each other out in pairs, only the true majority survives.

### ✅ 3. HashMap Is a Safe Starting Point

Use it when clarity matters more than space optimization.

### ✅ 4. Boyer–Moore Is a Pattern

This technique appears in other problems involving dominance or >50% conditions.

---

## ⏱️ Time Complexity

### HashMap Solution

**Time: O(n)**

* One pass through the array
* Constant-time dictionary operations

**Space: O(n)**

* Stores frequency of each unique element

---

### Boyer–Moore Solution

**Time: O(n)**

* Single pass through the array

**Space: O(1)**

* Only two variables (`candidate`, `voteCount`)
* No extra data structures
