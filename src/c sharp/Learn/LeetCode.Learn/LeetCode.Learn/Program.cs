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
            FindNumbersWithEvenNumberOfDigits_Main(args);
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
    }
}
