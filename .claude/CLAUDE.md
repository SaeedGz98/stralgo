# 📝 README Template for Algorithm Challenges

This document defines the **exact structure and style** for all challenge README files in this project.

---

## 📋 Standard Structure

Every challenge README must follow this **exact order**:

```markdown
# 🔹 [Problem Name] — Clean & Compact Interview Notes

📌 **LeetCode:** [URL]

---

## 👉 Problem Summary

[2-4 sentence clear problem statement]
[Include key constraints or guarantees]

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"[Key phrase 1]"**
**"[Key phrase 2]"**

Immediately trigger this thought:

🔔 **[Core technique with specifics - mention data structure/algorithm by name]**

**Why?** [One sentence explaining the connection between problem and solution]

[Optional: 2-3 bullet points clarifying the approach]
- Left pointer = [role]
- Right pointer = [role]

---

## 🧠 Idea → Why [Technique Name]?

[2-4 paragraphs explaining:]
- Why this technique fits naturally
- Step-by-step thought process
- Key insight that makes it work

[Optional: pseudocode or algorithm steps as a numbered list]

---

## ✔️ C# Solution

```csharp
[Actual working C# code]
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. [First Tip Title]

[1-2 sentences explaining the tip]

[Optional: Code example or quote]

### ✅ 2. [Second Tip Title]

[1-2 sentences explaining the tip]

### ✅ 3. [Third Tip Title]

[1-2 sentences explaining the tip]

### ✅ 4. [Fourth Tip Title]

[1-2 sentences explaining the tip]

---

## ⏱️ Time Complexity

**Time: O([complexity])**

- [Explanation line 1]
- [Explanation line 2]

**Space: O([complexity])**

- [Explanation of space usage]
```

---

## 🎨 Style Guidelines

### ✅ Tone & Voice
- **Concise and direct** — no fluff
- **Interview-focused** — emphasizes pattern recognition
- **Confident but not verbose** — avoid words like "obviously," "simply," etc.
- **Active voice** — "Use a stack" not "A stack can be used"

### ✅ Emoji Usage
- `🔹` — Title
- `📌` — LeetCode link
- `👉` — Problem Summary
- `🧠` — Thinking/Idea sections
- `🔔` — Core trigger/technique
- `✔️` — Solution header
- `🎯` — Tips section
- `✅` — Individual tips
- `⏱️` — Complexity section

### ✅ Formatting
- Use **bold** for key terms and phrases
- Use `code formatting` for variable names, functions, data structures
- Use `---` horizontal rules between major sections
- Keep code blocks clean with proper C# syntax
- Use blockquotes (`>`) sparingly, only for memorable quotes

### ✅ Section-Specific Rules

#### 1. **Title**
Format: `# 🔹 [Problem Name] — Clean & Compact Interview Notes`

#### 2. **Problem Summary**
- 2-4 sentences maximum
- State the core task clearly
- Mention key constraints or guarantees
- No need to repeat full problem description from LeetCode

#### 3. **How to Think (Interview Trigger)**
- **Most important section** — this trains pattern recognition
- Start with "When you see:" followed by 2 key phrases
- Use 🔔 emoji before the core technique
- **Must explicitly name** the data structure/algorithm (HashMap, Stack, Two Pointers, etc.)
- Add "Why?" explanation connecting problem → solution
- Optional: bullet points clarifying roles (e.g., left pointer, right pointer)

#### 4. **Idea → Why [Technique]?**
- Title must reference the technique name (e.g., "Why Stack?", "Why HashMap?")
- Explain the natural fit between problem and technique
- Break down the approach step-by-step
- Include the "aha moment" or key insight

#### 5. **C# Solution**
- Include the actual working code
- Must be clean, readable, and idiomatic C#
- Use modern C# features (e.g., `new()`, `TryAdd`, etc.)
- Code should match the explanation above

#### 6. **Tips & Tricks**
- **Always exactly 4 tips**
- Each tip has a bolded title with ✅
- Keep each tip to 1-3 sentences
- Focus on practical, reusable insights
- Format: `### ✅ [Number]. [Title]`

#### 7. **Time Complexity**
- Include both **Time** and **Space**
- Use Big-O notation
- Provide 2-3 bullet points explaining why
- Be specific (e.g., "You visit each node exactly once")

---

## 📚 Reference Examples

### Example 1: HashMap Pattern (Two Sum)
- **Trigger**: "Find two numbers that add up to X" → Use complements
- **Technique**: HashMap for O(1) lookups
- **Key insight**: `remaining = target - nums[i]`

### Example 2: Stack Pattern (Valid Parentheses)
- **Trigger**: "Last opened, first closed" → Use a Stack (LIFO)
- **Technique**: Stack for nested structures
- **Key insight**: Opening brackets push, closing brackets pop and validate

### Example 3: Two Pointers Pattern (Merge Two Sorted Lists)
- **Trigger**: "Both lists are sorted" → Two-pointer technique
- **Technique**: Move through both lists simultaneously
- **Key insight**: Dummy head simplifies edge cases

### Example 4: Sliding Window Pattern (Best Time to Buy and Sell Stock)
- **Trigger**: "Must buy before sell" + "maximize profit" → Two pointers sliding window
- **Technique**: Track minimum (left) and scan for max profit (right)
- **Key insight**: Left = cheapest price so far, Right = current price

---

## 🔍 Pattern Recognition Keywords

When writing the "How to Think" section, look for these problem patterns:

| **Pattern** | **Keywords/Phrases** | **Technique** |
|-------------|---------------------|---------------|
| **HashMap** | "Find two numbers that sum to", "check if exists", "frequency count" | HashMap/Dictionary for O(1) lookup |
| **Stack** | "Last in, first out", "matching pairs", "nested structure", "valid parentheses" | Stack (LIFO) |
| **Two Pointers** | "Sorted arrays/lists", "merge", "find pair", "opposite ends" | Two pointers moving toward each other |
| **Sliding Window** | "Subarray/substring", "consecutive elements", "maximize/minimize in range" | Two pointers moving same direction |
| **Binary Search** | "Sorted array", "find in O(log n)", "search space can be halved" | Binary search |
| **Linked List** | "Reverse", "detect cycle", "merge nodes", "in-place" | Pointer manipulation |
| **DFS/BFS** | "Tree/graph traversal", "all paths", "shortest path" | Recursion or Queue |
| **Dynamic Programming** | "Optimal substructure", "overlapping subproblems", "count ways" | DP array/memoization |

---

## ✨ Quality Checklist

Before finalizing a README, verify:

- [ ] Title uses 🔹 emoji and "Clean & Compact Interview Notes"
- [ ] LeetCode link is present and correct
- [ ] "How to Think" section explicitly names the technique (HashMap, Stack, etc.)
- [ ] 🔔 trigger is clear and actionable
- [ ] "Why?" explanation connects problem to solution
- [ ] Code is actual working C# code, properly formatted
- [ ] Exactly 4 tips with ✅ emoji
- [ ] Time and Space complexity both included with explanations
- [ ] No unnecessary emojis or fluff
- [ ] Consistent formatting (spacing, bold, code blocks)
- [ ] Horizontal rules (`---`) between all major sections

---

## 🚀 Usage Instructions for Claude

When asked to create a new challenge README:

1. **Read the code file** to understand the solution
2. **Identify the core pattern** (HashMap, Stack, Two Pointers, etc.)
3. **Follow the template structure exactly** — do not skip sections
4. **Focus on the interview trigger** — what makes you think of this technique?
5. **Keep it concise** — this is "Clean & Compact" notes, not a textbook
6. **Use the reference examples** for tone and style
7. **Verify against the checklist** before finishing

---

**Version:** 1.0
**Last Updated:** 2025-11-23
**Maintained By:** stralgo project
