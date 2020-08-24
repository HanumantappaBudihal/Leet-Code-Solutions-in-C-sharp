using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/930/
    //Solution :https://leetcode.com/submissions/detail/385859148/
    class BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            PostorderTraversal(root, result);

            return result;
        }

        private void PostorderTraversal(TreeNode root, IList<int> result)
        {
            if (root is null)
                return;

            PostorderTraversal(root.left, result);
            PostorderTraversal(root.right, result);

            result.Add(root.val);
        }
    }
}
