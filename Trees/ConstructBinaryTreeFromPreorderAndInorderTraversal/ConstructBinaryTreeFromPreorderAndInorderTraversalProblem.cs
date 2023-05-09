using System;

namespace Trees.ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    public static class ConstructBinaryTreeFromPreorderAndInorderTraversalProblem
    {
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder is null || preorder.Length == 0 || inorder is null || inorder.Length == 0)
                return null;

            TreeNode root = new(preorder[0]);
            int mid = Array.IndexOf(inorder, preorder[0]);
            root.left = BuildTree(preorder[1..(mid + 1)], inorder[..mid]);
            root.right = BuildTree(preorder[(mid + 1)..], inorder[(mid + 1)..]);

            return root;
        }
    }
}