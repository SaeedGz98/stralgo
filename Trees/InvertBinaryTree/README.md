# 🔹 Invert Binary Tree — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/invert-binary-tree](https://leetcode.com/problems/invert-binary-tree)

---

## 👉 Problem Summary

You are given the root of a binary tree and must **invert** it by swapping every left and right child recursively.
The structure of the tree remains the same, but each subtree is mirrored.
If the tree is empty, return an empty tree.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Swap left and right child for every node"**
**"Mirror the binary tree"**

Immediately trigger this thought:

🔔 **Use Depth-First Search (DFS) recursion**

**Why?** Each subtree needs to be inverted the same way as the whole tree — a perfect fit for recursion.

* Each node does a simple swap: `left ↔ right`
* Then recurse into both children
* Base case: if the node is `null`, return

---

## 🧠 Idea → Why DFS Recursion?

Inversion is a naturally recursive problem:
each subtree is a smaller version of the original tree.

### Step-by-step reasoning:

1. If the node is `null`, nothing to invert.
2. Swap the left and right children.
3. Recursively invert each child subtree.
4. Return the current node after modification.

### Algorithm steps:

1. Base case: return `null` if node is empty
2. Swap `left` and `right`
3. Recurse into new `left`
4. Recurse into new `right`
5. Return the node

---

## ✔️ C# Solution

```csharp
public static TreeNode InvertTree(TreeNode root)
{
    if (root is null)
        return null;

    (root.right, root.left) = (root.left, root.right);

    InvertTree(root.left);
    InvertTree(root.right);

    return root;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Use Recursion for Tree-Mirroring Tasks

Binary tree transformations usually map naturally to recursive DFS because each subtree is processed the same way.

### ✅ 2. Swap First, Then Recurse

Swapping before recursion ensures children are inverted in their new positions.

### ✅ 3. Remember the Null Base Case

Always check for `null` at the start to avoid unnecessary recursion calls.

### ✅ 4. This Mirrors the Tree, Not Rebuilds It

You reuse existing nodes and only swap pointers — no new allocations needed.

---

## ⏱️ Time Complexity

**Time: O(n)**

* You visit every node once
* Each visit performs only a constant-time swap

**Space: O(h)**

* Recursion depth equals tree height
* `h` = log n for balanced trees, up to `n` for skewed trees