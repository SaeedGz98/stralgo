using System;

namespace Trees.BalancedBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static class BalancedBinaryTreeProblem
    {
        public static bool IsBalanced(TreeNode root)
        {
            return CheckBalance(root).isBalanced;
        }

        private static (int height, bool isBalanced) CheckBalance(TreeNode node)
        {
            if (node == null)
                return (0, true);

            (int height, bool isBalanced) left = CheckBalance(node.left);
            if (!left.isBalanced)
                return (0, false);

            (int height, bool isBalanced) right = CheckBalance(node.right);
            if (!right.isBalanced)
                return (0, false);

            if (Math.Abs(left.height - right.height) > 1)
                return (0, false);

            int currentHeight = Math.Max(left.height, right.height) + 1;

            return (currentHeight, true);
        }
    }
}
