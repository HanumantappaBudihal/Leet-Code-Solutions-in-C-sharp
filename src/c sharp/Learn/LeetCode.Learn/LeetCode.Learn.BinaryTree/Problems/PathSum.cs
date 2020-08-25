using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : eehttps://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/537/
    //Solution : https://leetcode.com/submissions/detail/386137741/
    class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root is null)
                return false;
            else if (root.val == sum && (root.left == null && root.right == null))
                return true;

            return (HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val));
        }
    }
}
