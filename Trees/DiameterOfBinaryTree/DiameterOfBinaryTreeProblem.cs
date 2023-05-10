using System;

namespace Trees.DiameterOfBinaryTree
{
    public class DiameterOfBinaryTreeProblem
    {
        private int result = -1;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Dfs(root);
            return result;
        }

        private int Dfs(TreeNode current)
        {
            if (current == null)
            {
                return -1;
            }
            int left = 1 + Dfs(current.left);
            int right = 1 + Dfs(current.right);
            result = Math.Max(result, (left + right));
            return Math.Max(left, right);
        }
    }
}