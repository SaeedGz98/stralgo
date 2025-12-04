# 🔹 Balanced Binary Tree — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/balanced-binary-tree](https://leetcode.com/problems/balanced-binary-tree)

---

## 👉 Problem Summary

Given a binary tree, determine if it is height-balanced.
A height-balanced binary tree is one where the depth of the two subtrees of every node differs by no more than 1.
You must check this property for every node in the tree, not just the root.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Height-balanced"**
**"Depth of two subtrees differs by at most 1"**

Immediately trigger this thought:

🔔 **Use bottom-up DFS with tuple return `(height, isBalanced)` to avoid recalculating heights**

**Why?** Balance depends on height comparison, and you must check every node. Calculating height separately for each node leads to O(n²) time. Instead, calculate height once during DFS and return both height and balance status together in a single pass.

**Interview thought process:**
- Naive approach: For each node, calculate left height, right height, compare → O(n²)
- Better approach: Calculate height once while checking balance → O(n)
- How? Return both values as a tuple from each recursive call
- Early exit: If any subtree is unbalanced, propagate `false` immediately

---

## 🧠 Idea → Why DFS with Tuple Return?

Checking balance requires knowing the height of left and right subtrees at every node.
A bottom-up DFS approach calculates heights while checking the balance property, avoiding redundant traversals.

### Step-by-step reasoning:

1. A tree is balanced if:
   - Left subtree is balanced
   - Right subtree is balanced
   - Height difference between left and right is ≤ 1

2. Use recursion to process children first (post-order traversal).
3. Return a tuple: `(height, isBalanced)` from each recursive call.
4. Early exit: if any subtree is unbalanced, immediately return `(0, false)`.
5. Calculate current height: `max(left.height, right.height) + 1`.

### Algorithm steps:

1. Base case: if `node == null`, return `(0, true)`
2. Recursively check left subtree → get `(leftHeight, leftBalanced)`
3. If left is unbalanced, early return `(0, false)`
4. Recursively check right subtree → get `(rightHeight, rightBalanced)`
5. If right is unbalanced, early return `(0, false)`
6. Check height difference: if `|leftHeight - rightHeight| > 1`, return `(0, false)`
7. Otherwise, return `(max(leftHeight, rightHeight) + 1, true)`

---

## ✔️ C# Solution

```csharp
public static bool IsBalanced(TreeNode root)
{
    return CheckBalance(root).isBalanced;
}

private static (int height, bool isBalanced) CheckBalance(TreeNode node)
{
    if (node == null)
        return (0, true);

    var left = CheckBalance(node.left);
    if (!left.isBalanced)
        return (0, false);

    var right = CheckBalance(node.right);
    if (!right.isBalanced)
        return (0, false);

    if (Math.Abs(left.height - right.height) > 1)
        return (0, false);

    int currentHeight = Math.Max(left.height, right.height) + 1;

    return (currentHeight, true);
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Use Tuple Returns for Multi-Value Propagation

When you need to track multiple pieces of information (height + validity), tuple returns eliminate the need for global variables or class wrappers.

### ✅ 2. Bottom-Up DFS Avoids Redundant Work

Processing children before the parent (post-order) ensures you calculate each node's height exactly once while checking balance.

### ✅ 3. Early Exit Optimization Saves Computation

As soon as you detect an unbalanced subtree, return immediately without processing the rest of the tree.

### ✅ 4. Height Formula is Always Max + 1

The height of a node is always `max(leftHeight, rightHeight) + 1` — this is the core recursive relation for tree height.

---

## ⏱️ Time Complexity

**Time: O(n)**

- You visit each node exactly once
- Each visit performs constant-time operations (comparisons, max, addition)

**Space: O(h)**

- Recursion stack depth equals tree height
- `h` = log n for balanced trees, up to `n` for skewed trees
