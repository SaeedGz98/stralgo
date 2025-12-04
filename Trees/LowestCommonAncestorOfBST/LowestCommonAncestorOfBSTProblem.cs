namespace Trees.LowestCommonAncestorOfBST
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

    public static class LowestCommonAncestorOfBSTProblem
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode cur = root;

            while (cur != null)
            {
                if (p.val > cur.val && q.val > cur.val)
                {
                    cur = cur.right;
                }
                else if (p.val < cur.val && q.val < cur.val)
                {
                    cur = cur.left;
                }
                else
                {
                    return cur;
                }
            }

            return cur;
        }
    }
}
