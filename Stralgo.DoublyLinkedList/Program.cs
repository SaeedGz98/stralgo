DoublyLinkedList<int> doublyLinkedList = new();

doublyLinkedList.AddFirst(3);
doublyLinkedList.AddFirst(4);
doublyLinkedList.AddLast(1);
doublyLinkedList.AddFirst(5);
doublyLinkedList.AddLast(7);
doublyLinkedList.AddFirst(2);

doublyLinkedList.RemoveFirst();

doublyLinkedList.RemoveLast();

doublyLinkedList.RemoveAt(3);

Console.WriteLine(doublyLinkedList);

Console.ReadLine();