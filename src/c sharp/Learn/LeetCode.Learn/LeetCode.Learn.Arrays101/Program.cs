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
            //SquaresOfSortedArray_Main(args);

            //4.DuplicateZero(args)
            //DuplicateZeros_Main(args);

            //5.RemoveElement_Main
            //RemoveElement_Main(args);

            //6.RemoveDuplicatesFromSortedArray
            //RemoveDuplicatesFromSortedArray_Main(args);

            //7.CheckIfNAndItsDoubleExist
            //CheckIfNAndItsDoubleExist_Main(args);

            //8.ValidMountainArrayProblem
            //ValidMountainArrayProblem_Main(args);

            //9.ReplaceElementsWithGreatestElementOnRightSide
            //ReplaceElementsWithGreatestElementOnRightSide_Main(args);

            //10.MoveZeroesProblem
            //MoveZeroesProblem_Main(args);

            //11.SortArrayByParityProblem
            //SortArrayByParityProblem_Main(args);

            //12.HeightCheckerProblem
            //HeightCheckerProblem_Main(args);

            //13.ThirdMaximumNumber
            ThirdMaximumNumber_Main(args);
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

        //4.
        static void DuplicateZeros_Main(string[] args)
        {
            DuplicateZerosProblem duplicateZerosProblem = new DuplicateZerosProblem();

            //Test Case 1
            //Input:[1,0,2,3,0,4,5,0]
            //Output: null
            //Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
            var items = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            duplicateZerosProblem.DuplicateZeros(items);

            //Test Case 2
            items = new int[] { 1, 2, 3 };
            //Expected result : {1, 2, 3}
            //Explanation: After calling your function, the input array is modified to: [1,2,3]
            duplicateZerosProblem.DuplicateZeros(items);

            //Test Case 3
            items = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            //Expected result : {0,0,0,0,0,0,0}
            //Explanation: After calling your function, the input array is modified to: [0,0,0,0,0,0,0]
            duplicateZerosProblem.DuplicateZeros(items);
        }

        //5.
        static void RemoveElement_Main(string[] args)
        {
            RemoveElementProblem removeElementProblem = new RemoveElementProblem();

            //Test Case 1
            //Given nums = [3, 2, 2, 3], val = 3,
            //Your function should return length = 2, with the first two elements of nums being 2.
            //It doesn't matter what you leave beyond the returned length.     var items = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            var items = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            removeElementProblem.RemoveElement(items, val);

            //test 2
            items = new int[] { 3, 2, 2, 3 };
            val = 3;
            removeElementProblem.RemoveElement(items, val);
        }

        //6.RemoveDuplicatesFromSortedArray
        static void RemoveDuplicatesFromSortedArray_Main(string[] args)
        {
            RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();

            //Test Case 1
            //Given nums = [1,1,2]
            //Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
            //It doesn't matter what you leave beyond the returned length.            var items = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };          
            var items = new int[] { 1, 1, 2 };
            removeDuplicatesFromSortedArray.RemoveDuplicates(items);

            //test 2
            items = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            removeDuplicatesFromSortedArray.RemoveDuplicates(items);
        }

        //7.CheckIfNAndItsDoubleExist
        static void CheckIfNAndItsDoubleExist_Main(string[] args)
        {
            CheckIfNAndItsDoubleExist checkIfNAndItsDoubleExist = new CheckIfNAndItsDoubleExist();

            //Test Case 1
            //Input: arr = [10, 2, 5, 3]
            //Output: true
            //Explanation: N = 10 is the double of M = 5,that is, 10 = 2 * 5.var items = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };          
            var items = new int[] { 10, 2, 5, 3 };
            checkIfNAndItsDoubleExist.CheckIfExist(items);

            //Test 2
            //Input: arr = [7, 1, 14, 11]
            //Output: true
            //Explanation: N = 14 is the double of M = 7,that is, 14 = 2 * 7.
            items = new int[] { 7, 1, 14, 11 };
            checkIfNAndItsDoubleExist.CheckIfExist(items);

            //Test 3
            //Input: arr = [3, 1, 7, 11]
            //Output: false
            //Explanation: In this case does not exist N and M, such that N = 2 * M.
            items = new int[] { 3, 1, 7, 11 };
            checkIfNAndItsDoubleExist.CheckIfExist(items);

            //Edge case 1
            //[-2,0,10,-19,4,6,-8] : expected ans : true
            items = new int[] { -2, 0, 10, -19, 4, 6, -8 };
            checkIfNAndItsDoubleExist.CheckIfExist(items);

            //Test 5 :
            //[0,0] Expected output : true
            items = new int[] { 0, 0 };
            checkIfNAndItsDoubleExist.CheckIfExist(items);
        }

        //8.ValidMountainArrayProblem
        static void ValidMountainArrayProblem_Main(string[] args)
        {
            ValidMountainArrayProblem validMountainArrayProblem = new ValidMountainArrayProblem();

            //Test Case 1
            //Input: [2,1]
            //Output: false
            var items = new int[] { 2, 1 };
            var result = validMountainArrayProblem.ValidMountainArray(items);

            //Test 2
            //Input: [3,5,5]
            //Output: false            
            items = new int[] { 3, 5, 5 };
            result = validMountainArrayProblem.ValidMountainArray(items);

            //Test 3
            //Input: arr = [0,3,2,1]
            //Output: true
            items = new int[] { 0, 3, 2, 1 };
            result = validMountainArrayProblem.ValidMountainArray(items);

            //Test4
            //Input : [9,8,7,6,5,4,3,2,1,0]
            //output : false
            items = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            result = validMountainArrayProblem.ValidMountainArray(items);
        }

        //9.ReplaceElementsWithGreatestElementOnRightSide
        static void ReplaceElementsWithGreatestElementOnRightSide_Main(string[] args)
        {
            ReplaceElementsWithGreatestElementOnRightSide replaceElementsWithGreatestElementOnRightSide = new ReplaceElementsWithGreatestElementOnRightSide();

            //Test Case 1
            //Input: arr = [17, 18, 5, 4, 6, 1]
            //Output:[18,6,6,6,1,-1]
            var items = new int[] { 17, 18, 5, 4, 6, 1 };
            var result = replaceElementsWithGreatestElementOnRightSide.ReplaceElements(items);
        }

        //10.MoveZeroesProblem
        static void MoveZeroesProblem_Main(string[] args)
        {
            MoveZeroesProblem moveZeroesProblem = new MoveZeroesProblem();
            //Test Case 1
            //Input: arr = [0,1,0,3,12]
            //Output:[1,3,12,0,0]
            var items = new int[] { 0, 1, 0, 3, 12 };
            moveZeroesProblem.MoveZeroes(items);
        }

        //11.SortArrayByParityProblem
        static void SortArrayByParityProblem_Main(string[] args)
        {
            SortArrayByParityProblem sortArrayByParityProblem = new SortArrayByParityProblem();

            //Input: [3,1,2,4]
            //Output: [2,4,3,1]
            //The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
            var items = new int[] { 3, 1, 2, 4 };
            sortArrayByParityProblem.SortArrayByParity(items);
        }

        //12.HeightCheckerProblem
        private static void HeightCheckerProblem_Main(string[] args)
        {
            HeightCheckerProblem heightCheckerProblem = new HeightCheckerProblem();

            /*
             * Input: heights = [1,1,4,2,1,3]
               Output: 3
               Explanation: 
               Current array : [1,1,4,2,1,3]
               Target array  : [1,1,1,2,3,4]
               On index 2 (0-based) we have 4 vs 1 so we have to move this student.
               On index 4 (0-based) we have 1 vs 3 so we have to move this student.
               On index 5 (0-based) we have 3 vs 4 so we have to move this student.
             */
            var items = new int[] { 1, 1, 4, 2, 1, 3 };
            heightCheckerProblem.HeightChecker(items);
        }

        //13.
        static void ThirdMaximumNumber_Main(string[] args)
        {
            ThirdMaximumNumber thirdMaximumNumber = new ThirdMaximumNumber();
            /*
             * Example 1:
               Input: [3, 2, 1,4]
               Output: 2
               Explanation: The third maximum is 1.
             */
            var items = new int[] { 3, 2, 1, 4 };
            var result = thirdMaximumNumber.ThirdMax(items);

            /*
             * Example 2:
               Input: [1, 2]
               Output: 2
               Explanation: The third maximum does not exist, so the maximum (2) is returned instead.
             */
            items = new int[] { 1, 2 };
            result = thirdMaximumNumber.ThirdMax(items);

            /*
             Input: [2, 2, 3, 1]
             Output: 1
             Explanation: Note that the third maximum here means the third maximum distinct number.
             Both numbers with value 2 are both considered as second maximum.
             */

            items = new int[] { 2, 2, 3, 1 };
            result = thirdMaximumNumber.ThirdMax(items);

            //Test 4 
            items = new int[] { 1, 1, 2 };
            //out put : 2
            result = thirdMaximumNumber.ThirdMax(items);

            //Test 5
            items = new int[] { 1, 2, -2147483648 };
            //out put : -2147483648 // Int32.MinValue
            result = thirdMaximumNumber.ThirdMax(items);
        }
    }
}
