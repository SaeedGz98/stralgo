using System;
using Trees.BinaryTreeMaximumPathSum;

var maxPath = BinaryTreeMaximumPathSumProblem.MaxPathSum(new(-10, new(9), new(20, new(15), new(7))));

Console.WriteLine(maxPath);