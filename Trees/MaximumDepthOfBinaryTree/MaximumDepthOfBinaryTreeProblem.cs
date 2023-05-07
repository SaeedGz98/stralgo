using System;
using System.Collections.Generic;

namespace Trees.MaximumDepthOfBinaryTree
{
    public static class MaximumDepthOfBinaryTreeProblem
    {
        public static int MaxDepth(TreeNode root)
        {
            //---Recursive DFS(Inorder)---
            //if (root is null)
            //    return 0;

            //return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));

            //---BFS---
            //if (root is null)
            //    return 0;

            //int level = 0;
            //Queue<TreeNode> q = new Queue<TreeNode>(new List<TreeNode>() { root });

            //while (q.Count > 0)
            //{
            //    foreach (var i in Enumerable.Range(0, q.Count))
            //    {
            //        TreeNode node = q.Dequeue();

            //        if (node.left is not null)
            //            q.Enqueue(node.left);

            //        if (node.right is not null)
            //            q.Enqueue(node.right);
            //    }

            //    level++;
            //}

            //return level;

            //---Iterative DFS(PreOrder)---
            if (root is null)
                return 0;

            Stack<(TreeNode node, int depth)> stack = new(new List<(TreeNode node, int depth)>() { (root, 1) });
            int res = 1;

            while (stack.Count > 0)
            {
                (TreeNode node, int depth) = stack.Pop();

                if (node is not null)
                {
                    res = Math.Max(res, depth);
                    stack.Push((node.left, depth + 1));
                    stack.Push((node.right, depth + 1));
                }
            }

            return res;
        }
    }
}