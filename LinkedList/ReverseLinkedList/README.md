# 🔹 Reverse Linked List — Clean & Compact Interview Notes

📌 **LeetCode:** https://leetcode.com/problems/reverse-linked-list/

---

## 👉 Problem Summary

You are given the `head` of a **singly linked list**.  
Reverse the list **in-place** and return the new head of the reversed list.  
You must rearrange node pointers, not values.

---

## 🧠 How to Think (Interview Trigger)

When you see:

**"Reverse direction of connections"**  
**"Singly linked list with no backward pointers"**

Immediately trigger this thought:

🔔 **Pointer manipulation with iterative traversal**

**Why?** A singly linked list only points forward, so reversing requires re-wiring `next` pointers one by one.

- Current node = node being processed  
- Next node = saved before breaking the link  
- Previous node = new direction target  

---

## 🧠 Idea → Why Pointer Manipulation?

A singly linked list has a critical limitation:
- Once you move forward, you **cannot go back**

So the core challenge is:
> How do we reverse links without losing access to the rest of the list?

The solution uses **three pointers**:
1. `current` — walks through the list
2. `nextNode` — temporarily stores the next node before breaking the link
3. `reversedHead` — represents the already reversed portion

Step-by-step logic:
1. Save the next node
2. Reverse the current node’s pointer
3. Advance both pointers

The key insight:  
> Always save `next` **before** changing `current.next`.

This ensures no nodes are lost during reversal.

---

## ✔️ C# Solution

```csharp
public static ListNode ReverseList(ListNode head)
{
    ListNode reversedHead = null;
    ListNode current = head;

    while (current != null)
    {
        ListNode nextNode = current.next;

        current.next = reversedHead;
        reversedHead = current;
        current = nextNode;
    }

    return reversedHead;
}
````

---

## 🎯 Tips & Tricks (Short & Useful)

### ✅ 1. Save Next Before Rewiring

Always store `current.next` before changing pointers, or you lose the rest of the list.

### ✅ 2. Think in Segments

At every step, the list is split into **reversed** and **unprocessed** parts.

### ✅ 3. Iterative Is Safer Than Recursive

Avoids stack overflow and extra space in interviews.

### ✅ 4. Null Is a Valid Head

Returning `null` for an empty list is correct and expected.

---

## ⏱️ Time Complexity

**Time: O(n)**

* Each node is visited exactly once
* Constant work per node

**Space: O(1)**

* No extra data structures
* Only a few pointer variables are used
