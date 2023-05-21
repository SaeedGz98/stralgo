using Heap_PriorityQueue.FindMedianFromDataStream;
using System;

var finder = new MedianFinder();
finder.AddNum(1);
finder.AddNum(2);
Console.WriteLine(finder.FindMedian());
finder.AddNum(3);
Console.WriteLine(finder.FindMedian());
Console.ReadLine();