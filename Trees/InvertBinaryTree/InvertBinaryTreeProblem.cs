namespace Trees.InvertBinaryTree
{
    public static class InvertBinaryTreeProblem
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root is null)
                return null;

            (root.right, root.left) = (root.left, root.right);

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}