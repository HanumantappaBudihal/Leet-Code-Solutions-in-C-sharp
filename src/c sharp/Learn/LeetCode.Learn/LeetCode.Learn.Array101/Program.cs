using LeetCode.Learn.Arrays101.Problems;
using System;

namespace LeetCode.Learn.Arrays101
{
    //This is main entry point to test all solution
    //uncomment required code to run the particular problem ( only one main method should be uncommet at a time)
    class Program
    {
        //Default Main method
        //Call required Main method inside default Main method.
        //Example : FindNumbersWithEvenNumberOfDigits_Main() to execute the solution for
        //Find Numbers with Even Number of Digits
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //1.Max Consecutive Ones
            //MaxConsecutiveOnes_Main(args);

            //2. Find Numbers with Even Number of Digits    
            //FindNumbersWithEvenNumberOfDigits_Main(args);

            //3. Squares of a Sorted Array   
            SquaresOfSortedArray_Main(args);
        }

        //1. Max Consecutive Ones       
        static void MaxConsecutiveOnes_Main(string[] args)
        {
            MaxConsecutiveOnes maxConsecutiveOnes = new MaxConsecutiveOnes();

            // Test Case 1
            var items = new int[] { 1, 1, 0, 1, 1, 1 };
            //Expected result : 3
            var result1 = maxConsecutiveOnes.FindMaxConsecutiveOnes(items);

            //Test Case 2
        }

        //2. Find Numbers with Even Number of Digits    
        static void FindNumbersWithEvenNumberOfDigits_Main(string[] args)
        {
            FindNumbersWithEvenNumberOfDigits findNumbersWithEvenNumberOfDigits = new FindNumbersWithEvenNumberOfDigits();

            // Test Case 1
            var items = new int[] { 12, 345, 2, 6, 7896 };
            //Expected result : 2
            var result1 = findNumbersWithEvenNumberOfDigits.FindNumbers(items);

            //Test Case 2
        }

        //3. Squares of a Sorted Array   
        static void SquaresOfSortedArray_Main(string[] args)
        {
            SquaresOfSortedArray squaresOfSortedArray = new SquaresOfSortedArray();

            // Test Case 1
            var items = new int[] { -4, -1, 0, 3, 10 };
            //Expected result : {0,1,9,16,100}
            var result1 = squaresOfSortedArray.SortedSquares(items);

            //Test Case 2
             items = new int[] { -7, -3, 2, 3, 11 };
            //Expected result : {4,9,9,49,121}
            result1 = squaresOfSortedArray.SortedSquares(items);
        }
    }
}
