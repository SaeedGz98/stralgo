using System;
using Trees.MaximumDepthOfBinaryTree;

//InvertBinaryTreeProblem.InvertTree(new(4, new(2, new(1), new(3)), new(7, new(6), new(9))));

int depth = MaximumDepthOfBinaryTreeProblem.MaxDepth(new(3, new(9), new(20, new(15), new(7))));

Console.WriteLine(depth);