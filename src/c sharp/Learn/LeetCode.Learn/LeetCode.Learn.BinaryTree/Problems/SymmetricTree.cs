using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/536/
    //Solution :https://leetcode.com/submissions/detail/385927031/
    class SymmetricTree
    {
        //Method 1        
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric(root, root);
        }

        // For two trees to be mirror images,  
        // the following three conditions must be true  
        // 1 - Their root node's key must be same  
        // 2 - left subtree of left tree and right subtree  
        //       of right tree have to be mirror images  
        // 3 - right subtree of left tree and left subtree  
        //       of right tree have to be mirror images 
        private bool IsSymmetric(TreeNode root1, TreeNode root2)
        {
            if (root1 is null && root2 is null)
                return true;

            if (root1 != null && root2 != null && root1.val == root2.val)
                return (IsSymmetric(root1.left, root2.right) &&
                        IsSymmetric(root1.right, root2.left));

            return false;
        }

        //Method 2
        public bool IsSymmetric_Method2(TreeNode root)
        {
            if (root is null)
                return true;

            if (root.right is null && root.left != null)
                return false;

            if (root.right != null && root.left is null)
                return false;

            (int leftSumTreeSum, int rightSumTreeSum) = FindOutTheHighAndSumOfNodes(root);

            return (leftSumTreeSum == rightSumTreeSum);
        }

        private (int leftSumTreeSum, int rightSumTreeSum) FindOutTheHighAndSumOfNodes_Method2(TreeNode root)
        {
            if (root is null)
                return (0, 0);
            else
            {
                int leftSumTreeSum1 = 0, rightSumTreeSum1 = 0, leftSumTreeSum2 = 0, rightSumTreeSum2 = 0;
                if (root.left != null)
                {
                    (leftSumTreeSum1, rightSumTreeSum1) = FindOutTheHighAndSumOfNodes(root.left);
                    leftSumTreeSum1 = leftSumTreeSum1 + root.left.val;
                }

                if (root.right != null)
                {
                    (leftSumTreeSum2, rightSumTreeSum2) = FindOutTheHighAndSumOfNodes(root.right);
                    rightSumTreeSum2 = rightSumTreeSum2 + root.right.val;
                }

                return ((leftSumTreeSum1 + leftSumTreeSum2), (rightSumTreeSum1 + rightSumTreeSum2));
            }
        }
    }
}
