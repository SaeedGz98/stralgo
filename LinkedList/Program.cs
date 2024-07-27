using LinkedList.ReverseLinkedList;
using System;

ListNode listNode = new(1);
listNode.next = new(2);
listNode.next.next = new(3);
listNode.next.next.next = new(4);
listNode.next.next.next.next = new(5);

ListNode result = ReverseLinkedListProblem.ReverseList(listNode);

Console.WriteLine("|| LINKED LIST ||");