using System.Collections.Generic;
using System.Linq;

namespace Trees.BinaryTreeLevelOrderTraversal
{
    public static class BinaryTreeLevelOrderTraversalProblem
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> res = new();

            Queue<TreeNode> queue = new(new List<TreeNode>() { root });

            while (queue.Count > 0)
            {
                List<int> nodes = new();

                foreach (var i in Enumerable.Range(1, queue.Count))
                {
                    var node = queue.Dequeue();

                    if (node is not null)
                    {
                        nodes.Add(node.val);

                        if (node.left is not null)
                            queue.Enqueue(node.left);

                        if (node.right is not null)
                            queue.Enqueue(node.right);
                    }
                }

                if (nodes.Any())
                    res.Add(nodes);
            }

            return res.ToArray();
        }
    }
}