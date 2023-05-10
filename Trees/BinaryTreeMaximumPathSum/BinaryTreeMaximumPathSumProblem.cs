using System;

namespace Trees.BinaryTreeMaximumPathSum
{
    public static class BinaryTreeMaximumPathSumProblem
    {
        public static int MaxPathSum(TreeNode root)
        {
            int res = root.val;

            int dfs(TreeNode root)
            {
                if (root is null)
                    return 0;

                int leftMax = dfs(root.left);
                int rightMax = dfs(root.right);
                leftMax = Math.Max(leftMax, 0);
                rightMax = Math.Max(rightMax, 0);

                res = Math.Max(res, root.val + leftMax + rightMax);

                return root.val + Math.Max(leftMax, rightMax);
            }

            dfs(root);

            return res;
        }
    }
}