using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/929/
    //Solution : https://leetcode.com/submissions/detail/385856987/
    class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            InorderTraversal(root, result);

            return result;
        }

        private void InorderTraversal(TreeNode root, IList<int> result)
        {
            if (root is null)
                return;
            InorderTraversal(root.left, result);
            result.Add(root.val);
            InorderTraversal(root.right, result);
        }
    }
}
