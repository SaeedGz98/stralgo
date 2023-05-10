using System.Collections.Generic;

namespace Trees.KthSmallestElementInBST
{
    public static class KthSmallestElementInBSTProblem
    {
        public static int KthSmallest(TreeNode root, int k)
        {
            int result = -1;
            Stack<TreeNode> stack = new();

            TreeNode cur = root;

            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();

                k--;
                if (k == 0)
                {
                    result = cur.val;
                    break;
                }
                cur = cur.right;
            }
            return result;
        }
    }
}