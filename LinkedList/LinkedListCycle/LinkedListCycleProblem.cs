using System.Collections.Generic;

namespace LinkedList.LinkedListCycle
{
    public static class LinkedListCycleProblem
    {
        public static bool HasCycle(ListNode head)
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
    }
}