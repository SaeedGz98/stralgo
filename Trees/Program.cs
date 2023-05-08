using System;
using Trees.BinaryTreeLevelOrderTraversal;
using Trees.MaximumDepthOfBinaryTree;
using Trees.ValidateBinarySearchTree;

//var isValidBst = ValidateBinarySearchTreeProblem.IsValidBST(new(2, new(1), new(3)));
var isValidBst = ValidateBinarySearchTreeProblem.IsValidBST(new(5, new(1), new(4, new(3), new(6))));

Console.WriteLine(isValidBst);