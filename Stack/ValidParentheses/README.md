# 🔹 Valid Parentheses — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/valid-parentheses

---

## 👉 Problem Summary

Given a string containing only `()[]{}`, determine if the parentheses are valid.

A string is valid when:
- Each opening bracket has a matching closing bracket
- The match is of the same type
- Brackets close in the correct order (LIFO)

---

## 🧠 How to Think (Interview Trigger)

**When you see:**
- "Parentheses must close in order"
- "Last opened must close first"

**Immediately trigger:**

🔔 **Use a Stack (LIFO structure)**

Stacks perfectly model nested structures.

---

## 🧠 Idea → Why Stack?

Because the **last opened bracket must be closed first**, exactly like:
- HTML tags
- Function calls
- Nested expressions

For each character:
1. If it's an **opening bracket**, push it onto the stack.
2. If it's a **closing bracket**, check:
   - Is the stack empty? → invalid
   - Does the top of the stack match this closing type? → if not, invalid

At the end, the stack must be empty.

---

## ✔️ C# Solution

```csharp
public bool IsValid(string s)
{
    Dictionary<char, char> openToClose = new()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

    Stack<char> opens = new();

    foreach (char current in s)
    {
        if (openToClose.ContainsKey(current))
        {
            opens.Push(current);
        }
        else
        {
            if (opens.Count == 0)
                return false;

            char lastOpen = opens.Pop();

            if (openToClose[lastOpen] != current)
                return false;
        }
    }

    return opens.Count == 0;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Stacks = Nested Structure Problems

Whenever the rule is **"last opened, first closed,"** immediately think:

> "This is a stack problem."

---

### ✅ 2. Use a Mapping (Dictionary)

Mapping `open → close` helps quickly verify correctness:

```
( → )
[ → ]
{ → }
```

Keeps the code clean and avoids multiple if-conditions.

---

### ✅ 3. Empty Stack Check is Crucial

If you hit a closing bracket when the stack is empty → instantly invalid.

---

### ✅ 4. Final Stack Must Be Empty

If anything remains unmatched in the stack at the end → invalid.

---

## ⏱️ Time Complexity

**Time:** `O(n)`
- You process each character exactly once.
- Every push/pop operation on the stack is `O(1)`.

**Space:** `O(n)`
- In worst case (e.g., `"((({{{[[["`) you push all characters into the stack.
