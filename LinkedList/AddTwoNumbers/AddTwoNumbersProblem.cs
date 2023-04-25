namespace LinkedList.AddTwoNumbers
{
    public static class AddTwoNumbersProblem
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            int remain = 0;

            while (l1.next != null && l2.next != null)
            {
                int sum = remain + l1.val + l2.val;
                remain = sum % 10;

                tail.next = new(remain);

                l1 = l1.next;
                l2 = l2.next;
            }

            return l1;
        }
    }
}