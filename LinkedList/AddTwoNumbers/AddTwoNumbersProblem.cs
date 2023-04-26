namespace LinkedList.AddTwoNumbers
{
    public static class AddTwoNumbersProblem
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode cur = dummy;

            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;

                int sum = carry + v1 + v2;
                carry = sum / 10;
                cur.next = new(sum % 10);

                cur = cur.next;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            return dummy.next;
        }
    }
}