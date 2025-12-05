using System.Collections.Generic;

namespace LinkedList.LinkedListCycle
{
    public class LinkedListCycleProblem
    {
        // Approach 1: HashSet tracking - O(n) space
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new();
            bool hasCycle = false;

            while (!hasCycle && head != null)
            {
                hasCycle = !visited.Add(head);
                head = head.next;
            }

            return hasCycle;
        }

        // Approach 2: Floyd's Cycle Detection (Fast & Slow Pointers) - O(1) space
        public bool HasCycle2(ListNode head)
        {
            if (head == null)
                return false;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }

            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}