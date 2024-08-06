using LinkedList.LinkedListCycle;
using LinkedList.ReverseLinkedList;
using System;

LinkedList.ReverseLinkedList.ListNode listNode = new(1);
listNode.next = new(2);
listNode.next.next = new(3);
listNode.next.next.next = new(4);
listNode.next.next.next.next = new(5);

LinkedList.ReverseLinkedList.ListNode result = ReverseLinkedListProblem.ReverseList(listNode);

LinkedList.LinkedListCycle.ListNode listNode2 = new(1);
listNode.next = new(2);
listNode.next.next = new(3);
listNode.next.next.next = new(4);
listNode.next.next.next.next = new(5);

bool result2 = LinkedListCycleProblem.HasCycle(listNode2);

Console.WriteLine("|| LINKED LIST ||");