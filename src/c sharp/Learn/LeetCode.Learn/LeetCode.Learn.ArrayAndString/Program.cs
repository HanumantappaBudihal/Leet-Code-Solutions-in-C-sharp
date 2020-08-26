using LeetCode.Learn.ArrayAndString.Problems;
using Microsoft.VisualBasic;
using System;

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
            LargestNumberAtLeastTwiceOfOthers_Main();
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
