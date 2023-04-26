using LinkedList.LinkedListCycle;

ListNode node1 = new(3);
ListNode node2 = new(2);
ListNode node3 = new(0);
ListNode node4 = new(-4);

node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node2;

LinkedListCycleProblem.HasCycle(node1);