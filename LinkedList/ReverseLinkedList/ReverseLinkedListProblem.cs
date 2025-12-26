namespace LinkedList.ReverseLinkedList
{
    public static class ReverseLinkedListProblem
    {
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
    }
}