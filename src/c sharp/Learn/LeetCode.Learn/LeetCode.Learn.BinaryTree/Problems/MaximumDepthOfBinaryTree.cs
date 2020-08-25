using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/535/
    //Solution : https://leetcode.com/submissions/detail/385898296/
    class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            return FindDepthOfNode(root);
        }

        private int FindDepthOfNode(TreeNode root)
        {
            if (root is null)
                return 0;
            else
            {
                int leftSubTreeHeight = FindDepthOfNode(root.left);
                int rightSubTreeHeight = FindDepthOfNode(root.right);

                return Math.Max(leftSubTreeHeight, rightSubTreeHeight) + 1;
            }
        }
    }
}
