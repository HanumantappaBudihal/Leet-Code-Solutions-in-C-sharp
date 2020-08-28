using LeetCode.Learn.ArrayAndString.Problems;
using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace LeetCode.Learn.ArrayAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1.FindPivotIndex
            //FindPivotIndex_Main();

            //2.LargestNumberAtLeastTwiceOfOthers
            //LargestNumberAtLeastTwiceOfOthers_Main();

            //3.PlusOne Problem
            //PlusOne_Main();

            //4.DiagonalTraverse
            DiagonalTraverse_Main();
        }

        private static void DiagonalTraverse_Main()
        {
            DiagonalTraverse diagonalTraverse = new DiagonalTraverse();
            int[][] input = new int[3][] { new int[4] { 1, 2, 3, 4 },
                                           new int[4] { 5, 6, 7, 8 },
                                           new int[4] { 9, 10, 11, 12 } };

            var result = diagonalTraverse.FindDiagonalOrder(input);

            input = new int[3][] { new int[3] { 1, 2, 3 },
                                   new int[3] { 4, 5, 6 },
                                   new int[3] { 7, 8, 9 } };

            result = diagonalTraverse.FindDiagonalOrder(input);
        }
        private static void PlusOne_Main()
        {
            PlusOneProblem plusOneProblem = new PlusOneProblem();

            //Test case 1
            //Input: nums = [1,2,3]
            //Output: [1,2,4]

            var numbers = new int[] { 1, 2, 3 };
            var result = plusOneProblem.PlusOne(numbers);

            //Test case 2
            /*Input: nums = [4,3,2,1]
            Output: [4,3,2,2]*/

            numbers = new int[] { 4, 3, 2, 1 };
            result = plusOneProblem.PlusOne(numbers);

            //Test case 3
            // input : [0]
            // output : [1]
            result = plusOneProblem.PlusOne(new int[] { 0 });

            //Test case 4
            //input [9,9]
            //outpurt [1,0,0]
            result = plusOneProblem.PlusOne(new int[] { 9, 9 });
        }

        private static void LargestNumberAtLeastTwiceOfOthers_Main()
        {
            LargestNumberAtLeastTwiceOfOthers largestNumberAtLeastTwiceOfOthers = new LargestNumberAtLeastTwiceOfOthers();

            //Test case 1
            //Input: nums = [3, 6, 1, 0]
            //Output: 1

            var numbers = new int[] { 3, 6, 1, 0 };
            var result = largestNumberAtLeastTwiceOfOthers.DominantIndex(numbers);

            //Test case 2
            /*Input: nums = [1, 2, 3, 4]
            Output: -1*/

            numbers = new int[] { 1, 2, 3 };
            result = largestNumberAtLeastTwiceOfOthers.DominantIndex(numbers);

            //Test case 
            result = largestNumberAtLeastTwiceOfOthers.DominantIndex(new int[] { 1 });
        }

        private static void FindPivotIndex_Main()
        {
            FindPivotIndex findPivotIndex = new FindPivotIndex();
            //Test case 1
            //Input: nums = [1,7,3,6,5,6]
            //Output: 3

            var numbers = new int[] { 1, 7, 3, 6, 5, 6 };
            var result = findPivotIndex.PivotIndex(numbers);

            //Test case 2
            /*Input: nums = [1,2,3]
            Output: -1*/

            numbers = new int[] { 1, 2, 3 };
            result = findPivotIndex.PivotIndex(numbers);

            //Test case 3
            result = findPivotIndex.PivotIndex(null);

            //Test case 4
            result = findPivotIndex.PivotIndex(new int[] { 1 });
        }
    }
}
