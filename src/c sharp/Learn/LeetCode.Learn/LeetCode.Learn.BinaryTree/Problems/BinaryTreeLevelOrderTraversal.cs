using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement :https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/931/
    //My solution : 
    // Algorithm :

    /*Function to print level order traversal of tree*/
    //    printLevelorder(tree)
    //for d = 1 to height(tree)
    //   printGivenLevel(tree, d);

    //    /*Function to print all nodes at a given level*/
    //    printGivenLevel(tree, level)
    //if tree is NULL then return;
    //if level is 1, then
    //    print(tree->data);
    //else if level greater than 1, then
    //    printGivenLevel(tree->left, level-1);
    //    printGivenLevel(tree->right, level-1);

    //Problem statement : https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/931/
    //Solution : 
    class BinaryTreeLevelOrderTraversal
    {
            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                IList<IList<int>> result = new List<IList<int>>();
                int heightOfRoot = FindHeightOfNode(root);

                for (int i = 0; i < heightOfRoot; i++)
                {
                    List<int> subResult = new List<int>();
                    GetLevelData(root, i, subResult);

                    result.Add(subResult);
                }

                return result;
            }

            private void GetLevelData(TreeNode root, int level, List<int> subResult)
            {
                if (root is null)
                {
                    return;
                }

                if (level == 0)
                {
                    subResult.Add(root.val);
                }
                else if (level >= 1)
                {
                    GetLevelData(root.left, level - 1, subResult);
                    GetLevelData(root.right, level - 1, subResult);
                }
            }

            private int FindHeightOfNode(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    //Compute the height of the each subtree
                    int leftSubtreeHeight = FindHeightOfNode(root.left);
                    int rightSubtreeHeight = FindHeightOfNode(root.right);

                    if (leftSubtreeHeight > rightSubtreeHeight)
                        return leftSubtreeHeight + 1;
                    else
                        return rightSubtreeHeight + 1;
                }
            }
    }
}
