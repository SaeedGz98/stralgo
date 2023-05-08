namespace Trees.ValidateBinarySearchTree
{
    public static class ValidateBinarySearchTreeProblem
    {
        public static bool IsValidBST(TreeNode root)
        {
            return IsValid(root, long.MinValue, long.MaxValue);
        }

        public static bool IsValid(TreeNode node, int left, int right)
        {
            if (node is null)
                return true;

            if (!(node.val > left && node.val < right))
                return false;

            return IsValid(node.left, left, node.val) && IsValid(node.right, node.val, right);
        }
    }
}