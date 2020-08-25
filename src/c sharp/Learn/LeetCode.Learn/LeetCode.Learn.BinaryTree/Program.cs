using LeetCode.Learn.BinaryTree.Problems;
using System;

namespace LeetCode.Learn.BinaryTree
{
    class Program
    {
        /*Introduction
        A tree is a frequently-used data structure to simulate a hierarchical tree structure.

        Each node of the tree will have a root value and a list of references to other nodes which 
        are called child nodes. From graph view, a tree can also be defined as a directed acyclic
        graph which has N nodes and N-1 edges.

        A Binary Tree is one of the most typical tree structure. As the name suggests, a binary 
        tree is a tree data structure in which each node has at most two children, which are 
        referred to as the left child and the right child.

        By completing this card, you will be able to:

        Understand the concept of a tree and a binary tree;
        Be familiar with different traversal methods;
        Use recursion to solve binary-tree-related problems;
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1.BinaryTreePreorderTraversal
            //BinaryTreePreorderTraversal_Main();

            //2.BinaryTreeInorderTraversal
            //BinaryTreeInorderTraversal_Main();

            //3.BinaryTreePostorderTraversal
            //BinaryTreePostorderTraversal_Main();

            //4.BinaryTreeLevelOrderTraversal
            //BinaryTreeLevelOrderTraversal_Main();

            //5.MaximumDepthOfBinaryTree
            //MaximumDepthOfBinaryTree_Main();

            //6.SymmetricTree
            SymmetricTree_Main();
        }

        private static void SymmetricTree_Main()
        {
            SymmetricTree symmetricTree = new SymmetricTree();
            //Test 1
            /*Input: [3,9,20,null,null,15,7],
                 1
                / \
               2   2
              / \ / \
             3  4 4  3
            
            Output: true
            */

            TreeNode rootNode = new TreeNode(1);

            //Root-> Left
            TreeNode rootLeftChild1 = new TreeNode(2);
            rootNode.left = rootLeftChild1;

            //Root -> Right
            TreeNode rootRightChild1 = new TreeNode(2);
            rootNode.right = rootRightChild1;

            //Root -> Left ->left and Root -> Left ->right
            rootLeftChild1.left = new TreeNode(3);
            rootLeftChild1.right = new TreeNode(4);

            //Root -> right ->left and Root -> right ->right
            rootRightChild1.left = new TreeNode(4);
            rootRightChild1.right = new TreeNode(3);

            var result = symmetricTree.IsSymmetric(rootNode);

            //Test 2
            /*
                 1
                / \
               2   2
              / \ / \
             3  4 4  

            Output = fasle
            
             */
            //Set one left child as null;
            rootRightChild1.right = null;
            result = symmetricTree.IsSymmetric(rootNode);

            //Test 3
            // input [1]
            //output is true
            rootNode.left = null;
            rootNode.right = null;
            result = symmetricTree.IsSymmetric(rootNode);

            //TEst 4
            //input [1,2,3]
            rootNode.left = new TreeNode(2);
            rootNode.right = new TreeNode(3);

            result = symmetricTree.IsSymmetric(rootNode);

            //Test 5
            rootNode.left = new TreeNode(2);
            rootNode.right = new TreeNode(2);

            rootNode.left.left = new TreeNode(3);
            rootNode.left.right = new TreeNode(3);

            result = symmetricTree.IsSymmetric(rootNode);

            //Test 6

            rootNode.left = new TreeNode(0);
            rootNode.right = null;
            result = symmetricTree.IsSymmetric(rootNode);
        }

        private static void MaximumDepthOfBinaryTree_Main()
        {
            MaximumDepthOfBinaryTree maximumDepthOfBinaryTree = new MaximumDepthOfBinaryTree();

            //Test 1
            /*Input: [3,9,20,null,null,15,7],
                3
               / \
              9  20
                /  \
               15   7
            
            Output: 3
            */

            TreeNode rootNode = new TreeNode(3);

            TreeNode rootLeftChild1 = new TreeNode(9);
            rootNode.left = rootLeftChild1;

            TreeNode rootRightChild1 = new TreeNode(20);
            rootNode.right = rootRightChild1;

            //Assign the left child to rootRightChild
            TreeNode rightChild1Left = new TreeNode(15);
            rootRightChild1.left = rightChild1Left;
            //Right child to rootRightChild
            TreeNode rightChild1Right = new TreeNode(7);
            rootRightChild1.right = rightChild1Right;

            var result = maximumDepthOfBinaryTree.MaxDepth(rootNode);
        }

        private static void BinaryTreeLevelOrderTraversal_Main()
        {
            BinaryTreeLevelOrderTraversal binaryTreeLevelOrderTraversal = new BinaryTreeLevelOrderTraversal();

            //Test 1
            /*Input: [3,9,20,null,null,15,7],
                3
               / \
              9  20
                /  \
               15   7
            
            Output: [
                      [3],
                      [9,20],
                      [15,7]
                    ]
            */

            TreeNode rootNode = new TreeNode(3);

            TreeNode rootLeftChild1 = new TreeNode(9);
            rootNode.left = rootLeftChild1;

            TreeNode rootRightChild1 = new TreeNode(20);
            rootNode.right = rootRightChild1;

            //Assign the left child to rootRightChild
            TreeNode rightChild1Left = new TreeNode(15);
            rootRightChild1.left = rightChild1Left;
            //Right child to rootRightChild
            TreeNode rightChild1Right = new TreeNode(7);
            rootRightChild1.right = rightChild1Right;

            var result = binaryTreeLevelOrderTraversal.LevelOrder(rootNode);
        }

        private static void BinaryTreePostorderTraversal_Main()
        {
            BinaryTreePostorderTraversal binaryTreePostorderTraversal = new BinaryTreePostorderTraversal();

            //Test 1
            /*Input: [1,null,2,3]
            1
             \
              2
             /
            3
            Output: [3,2,1]
            */

            TreeNode rootNode = new TreeNode(1);

            TreeNode rootRightChild1 = new TreeNode(2);
            rootNode.right = rootRightChild1;

            //Assign the left child to rootRightChild
            TreeNode rightChild1Left = new TreeNode(3);
            rootRightChild1.left = rightChild1Left;

            var result = binaryTreePostorderTraversal.PostorderTraversal(rootNode);
        }

        private static void BinaryTreeInorderTraversal_Main()
        {
            BinaryTreeInorderTraversal binaryTreeInorderTraversal = new BinaryTreeInorderTraversal();

            //Test 1
            /*Input: [1,null,2,3]
            1
             \
              2
             /
            3
            Output: [1,3,2]
            */

            TreeNode rootNode = new TreeNode(1);

            TreeNode rootRightChild1 = new TreeNode(2);
            rootNode.right = rootRightChild1;

            //Assign the left child to rootRightChild
            TreeNode rightChild1Left = new TreeNode(3);
            rootRightChild1.left = rightChild1Left;

            var result = binaryTreeInorderTraversal.InorderTraversal(rootNode);
        }

        private static void BinaryTreePreorderTraversal_Main()
        {
            BinaryTreePreorderTraversal binaryTreePreorderTraversal = new BinaryTreePreorderTraversal();

            //Test 1
            /*Input: [1,null,2,3]
            1
             \
              2
             /
            3
            Output: [1,2,3]
            */

            TreeNode rootNode = new TreeNode(1);

            TreeNode rootRightChild1 = new TreeNode(2);
            rootNode.right = rootRightChild1;

            //Assign the left child to rootRightChild
            TreeNode rightChild1Left = new TreeNode(3);
            rootRightChild1.left = rightChild1Left;

            var result = binaryTreePreorderTraversal.PreorderTraversal(rootNode);
        }
    }
}
