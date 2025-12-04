# 🔹 Lowest Common Ancestor of a Binary Search Tree — Clean & Compact Interview Notes

📌 **LeetCode:** [https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree)

---

## 👉 Problem Summary

Given a Binary Search Tree (BST), find the lowest common ancestor (LCA) of two given nodes `p` and `q`.
The LCA is the lowest node in the tree that has both `p` and `q` as descendants (a node can be a descendant of itself).
The BST property guarantees that for any node, all left descendants are smaller and all right descendants are larger.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Binary Search Tree (BST)"**
**"Lowest Common Ancestor"**

Immediately trigger this thought:

🔔 **Use BST property for navigation (left < root < right) with iterative traversal**

**Why?** The BST property lets you navigate without searching the entire tree — if both nodes are smaller than current, go left; if both are larger, go right; otherwise, you've found the split point (the LCA).

- Current node = potential LCA being evaluated
- Navigate left when both `p` and `q` are smaller
- Navigate right when both `p` and `q` are larger
- Stop when values split (one left, one right) or match

---

## 🧠 Idea → Why BST Property?

The BST property provides a natural decision rule at each node:
if both target nodes are on the same side, the ancestor must be on that side too.
If they split (one left, one right), the current node is the split point — the LCA.

### Step-by-step reasoning:

1. Start at the root.
2. If both `p.val` and `q.val` are **greater** than `current.val`, both nodes must be in the right subtree → move right.
3. If both `p.val` and `q.val` are **less** than `current.val`, both nodes must be in the left subtree → move left.
4. If the values split (one smaller, one larger) or one matches `current.val`, then `current` is the LCA.
5. Return `current`.

### Algorithm steps:

1. Initialize `current = root`
2. While `current != null`:
   - If both `p.val > current.val` and `q.val > current.val` → go right
   - If both `p.val < current.val` and `q.val < current.val` → go left
   - Otherwise → return `current` (the split point)
3. Return `current`

---

## ✔️ C# Solution

```csharp
public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
    TreeNode current = root;

    while (current != null)
    {
        if (p.val > current.val && q.val > current.val)
        {
            current = current.right;
        }
        else if (p.val < current.val && q.val < current.val)
        {
            current = current.left;
        }
        else
        {
            return current;
        }
    }

    return current;
}
```

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Leverage the BST Property for O(h) Traversal

Unlike a general binary tree, a BST lets you prune entire subtrees based on value comparisons, making LCA search efficient.

### ✅ 2. The Split Point is Always the LCA

When one node is on the left and the other is on the right (or one matches current), you've found the lowest common ancestor.

### ✅ 3. Iterative Solution is Cleaner Than Recursive

This problem doesn't need recursion — a simple `while` loop with value comparisons is more readable and uses O(1) space.

### ✅ 4. No Need to Search for p and q

You don't need to verify that `p` and `q` exist in the tree — the problem guarantees both nodes are present.

---

## ⏱️ Time Complexity

**Time: O(h)**

- You traverse at most the height of the tree
- Each step eliminates half the tree (on average) in a balanced BST
- `h` = log n for balanced trees, up to `n` for skewed trees

**Space: O(1)**

- Iterative solution uses only a pointer variable
- No recursion stack or additional data structures
