using System;

namespace LinkedList.ReorderList
{
    public static class ReorderListProblem
    {
        public static void ReorderList(ListNode head)
        {
            //find middle
            ListNode slow = head, fast = head.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //reverse second half
            ListNode second = slow.next;
            ListNode prev = slow.next = null;

            while (second != null)
            {
                ListNode tmp = second.next;
                second.next = prev;
                prev = second;
                second = tmp;
            }

            //merge two halfs
            ListNode first = head;
            second = prev;

            Console.WriteLine($"first: {first}");
            Console.WriteLine($"second: {second}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            while (second != null)
            {
                ListNode tmp1 = first.next, tmp2 = second.next;

                Console.WriteLine($"tmp1: {tmp1}");
                Console.WriteLine($"tmp2: {tmp2}");
                Console.WriteLine($"head: {head}");


                first.next = second;

                Console.WriteLine($"first: {first}");
                Console.WriteLine($"head: {head}");


                second.next = tmp1;

                Console.WriteLine($"second: {second}");
                Console.WriteLine($"head: {head}");


                first = tmp1;

                Console.WriteLine($"first: {first}");
                Console.WriteLine($"head: {head}");


                second = tmp2;

                Console.WriteLine($"second: {second}");
                Console.WriteLine($"head: {head}");


                Console.WriteLine("-------------------");
            }
        }
    }
}