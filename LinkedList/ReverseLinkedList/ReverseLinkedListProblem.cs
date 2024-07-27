namespace LinkedList.ReverseLinkedList
{
    /// RECOMMENDED
    public static class ReverseLinkedListProblem
    {
        public static ListNode ReverseList(ListNode head)
        {
            //ListNode prev = null, curr = head;

            //while (curr != null)
            //{
            //    ListNode nxt = curr.next;
            //    curr.next = prev;
            //    prev = curr;
            //    curr = nxt;
            //}

            //return prev;

            if (head == null)
                return null;

            ListNode newHead = head;

            if (head.next != null)
            {
                newHead = ReverseList(head.next);
                head.next.next = head;
            }

            head.next = null;

            return newHead;
        }
    }
}