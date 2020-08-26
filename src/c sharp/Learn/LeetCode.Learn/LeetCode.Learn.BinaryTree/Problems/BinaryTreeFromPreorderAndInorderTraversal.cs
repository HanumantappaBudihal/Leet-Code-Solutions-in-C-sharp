using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeetCode.Learn.BinaryTree.Problems
{
    //Problem statement : 
    class BinaryTreeFromPreorderAndInorderTraversal
    {
        //Method 1
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || preorder.Length == 0 || inorder == null || inorder.Length == 0)
                return null;

            return BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }

        private TreeNode BuildTree(int[] preorder, int preorderStartIndex, int preorderEndIndex, int[] inorder, int inorderStartIndex, int inorderEndIndex)
        {
            if (preorderStartIndex > preorderEndIndex || inorderStartIndex > inorderEndIndex)
                return null;

            TreeNode node = new TreeNode(preorder[preorderStartIndex]);

            if (preorderStartIndex != preorderEndIndex)
            {
                int m = inorderStartIndex;

                for (; m < inorder.Length; m++)
                    if (inorder[m] == preorder[preorderStartIndex])
                        break;

                node.left = BuildTree(preorder, preorderStartIndex + 1, preorderStartIndex + m - inorderStartIndex, inorder, inorderStartIndex, m - 1);
                node.right = BuildTree(preorder, preorderStartIndex + 1 + m - inorderStartIndex, preorderEndIndex, inorder, m + 1, inorderEndIndex);
            }

            return node;
        }

        //Method 2 
        //public static int preOrderIndex = 0;

        //public TreeNode BuildTree(int[] preorder, int[] inorder)
        //{
        //    if (inorder is null || preorder is null)
        //        return null;

        //    var lenght = inorder.Length;
        //    if (lenght == 1)
        //        return new TreeNode(preorder[0]);

        //    return BuildTree(inorder, preorder, 0, lenght - 1);
        //}

        //public TreeNode BuildTree(int[] inorder, int[] preorder, int inorderStartIndex, int inorderEndIndex)
        //{
        //    if (inorderStartIndex > inorderEndIndex)
        //    {
        //        return null;
        //    }

        //    /* Pick current node from Preorder traversal using preIndex and increment preIndex */
        //    TreeNode binaryTreeNode = new TreeNode(preorder[preOrderIndex++]);

        //    /* If this node has no children then return */
        //    if (inorderStartIndex == inorderEndIndex)
        //    {
        //        return binaryTreeNode;
        //    }

        //    /* Else find the index of this node in Inorder traversal */
        //    int inorderIndex = search(inorder, inorderStartIndex, inorderEndIndex, binaryTreeNode.val);

        //    /* Using index in Inorder traversal, construct left and right subtress */
        //    binaryTreeNode.left = BuildTree(inorder, preorder, inorderStartIndex, inorderIndex - 1);
        //    binaryTreeNode.right = BuildTree(inorder, preorder, inorderIndex + 1, inorderEndIndex);

        //    return binaryTreeNode;
        //}

        ///* Function to find index of value in arr[start...end]  
        //   The function assumes that value is present in in[] */
        //public virtual int search(int[] tree, int strtIndex, int endIndex, int value)
        //{
        //    int iterator;

        //    for (iterator = strtIndex; iterator <= endIndex; iterator++)
        //    {
        //        if (tree[iterator] == value)
        //        {
        //            return iterator;
        //        }
        //    }

        //    return iterator;
        //}
    }
}
