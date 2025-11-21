# 🔹 Merge Two Sorted Lists — Clean & Compact Interview Notes

## 📌 LeetCode
https://leetcode.com/problems/merge-two-sorted-lists

## 👉 Problem Summary

You are given two sorted linked lists.
Your task is to merge them into a single sorted linked list by reusing the original nodes.

Return the head of the merged list.

## 🧠 How to Think (Interview Trigger)

When you see:

- "Merge two sorted lists"
- "Both lists are already sorted"

**Immediately trigger:**

### 🔔 Use the Two-Pointer technique

Move through both lists simultaneously and always pick the smaller node.

## 🧠 Idea → Why Dummy Head?

A `dummyHead` simplifies the logic:

- You don't need to handle the head separately
- You always attach nodes to `tail.next`
- At the end, return `dummyHead.next`

This avoids special-case bugs.

## ✔️ C# Solution
```csharp
public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode dummyHead = new();
    ListNode tail = dummyHead;

    while (list1 != null && list2 != null)
    {
        if (list1.val < list2.val)
        {
            tail.next = list1;
            list1 = list1.next;
        }
        else
        {
            tail.next = list2;
            list2 = list2.next;
        }
        tail = tail.next;
    }

    if (list1 != null)
    {
        tail.next = list1;
    }
    else if (list2 != null)
    {
        tail.next = list2;
    }

    return dummyHead.next;
}
```

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Always Think "Two Pointers" When Both Lists Are Sorted

Move through both lists simultaneously like merging two sorted arrays.

### ✅ 2. Use a Dummy Node to Simplify Logic

Removes the need to treat the head specially.
Keeps the code clean.

### ✅ 3. Attach the Remaining Nodes at the End

If one list is finished, the other is already sorted → attach it directly.

### ✅ 4. Never create new nodes unnecessarily

Re-use existing list nodes to keep the solution optimal.

## ⏱️ Time Complexity

**Time:** O(n + m)

You visit each node from both lists exactly once.

**Space:** O(1)

Uses constant extra space — only pointer manipulation.
