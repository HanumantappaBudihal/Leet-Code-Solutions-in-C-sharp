using System;
using System.Collections.Generic;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
    //Solution : https://leetcode.com/submissions/detail/385853132/
    class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> preOrder = new List<int>();
            PreorderTraversal(root, preOrder);

            return preOrder;
        }

        private void PreorderTraversal(TreeNode root, List<int> preOrder)
        {
            if (root is null)
                return;

            preOrder.Add(root.val);
            PreorderTraversal(root.left, preOrder);
            PreorderTraversal(root.right, preOrder);
        }
    }
}
