using System;
using Trees.BinaryTreeMaximumPathSum;
using Trees.KthSmallestElementInBST;

//var lowest = KthSmallestElementInBSTProblem.KthSmallest(new(3, new(1, null, new(2)), new(4)), 1);
var lowest = KthSmallestElementInBSTProblem.KthSmallest(new(5, new(3, new(2, new(1)), new(4)), new(6)), 3);
Console.WriteLine(lowest);