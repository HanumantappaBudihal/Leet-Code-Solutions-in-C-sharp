using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    //Problem Statement
    class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] numbers)
        {
            int length = numbers.Length;
            for (int iterator = 0; iterator < length; iterator++)
            {
                numbers[iterator] = numbers[iterator] * numbers[iterator];
            }

            //Sort using merge algorithms
            //MergeSort(numbers, 0, numbers.Length - 1);
            numbers.ToList().Sort();
            //result.Sort();
            return numbers;
        }

        //Merge Sort Algorithm

        //public void MergeSort(int[] input, int startIndex, int endIndex)
        //{
        //    int middleIndex;

        //    if (endIndex > startIndex)
        //    {
        //        middleIndex = (endIndex + startIndex) / 2;
        //        MergeSort(input, startIndex, middleIndex);
        //        MergeSort(input, (middleIndex + 1), endIndex);
        //        Merge(input, startIndex, (middleIndex + 1), endIndex);
        //    }
        //}

        //public void Merge(int[] input, int leftIndex, int middleIndex, int rightIndex)
        //{
        //    //Merge procedure takes theta(n) time
        //    int[] tempInput = new int[input.Length];
        //    int i, leftEnd, lengthOfInput, tempPosition;
        //    leftEnd = middleIndex - 1;
        //    tempPosition = leftIndex;
        //    lengthOfInput = rightIndex - leftIndex + 1;

        //    //selecting smaller element from left sorted array or right sorted array and placing them in temp array.
        //    while ((leftIndex <= leftEnd) && (middleIndex <= rightIndex))
        //    {
        //        if (input[leftIndex] <= input[middleIndex])
        //        {
        //            tempInput[tempPosition++] = input[leftIndex++];
        //        }
        //        else
        //        {
        //            tempInput[tempPosition++] = input[middleIndex++];
        //        }
        //    }

        //    //placing remaining element in temp from left sorted array
        //    while (leftIndex <= leftEnd)
        //    {
        //        tempInput[tempPosition++] = input[leftIndex++];
        //    }

        //    //placing remaining element in temp from right sorted array
        //    while (middleIndex <= rightIndex)
        //    {
        //        tempInput[tempPosition++] = input[middleIndex++];
        //    }

        //    //placing temp array to input
        //    for (i = 0; i < lengthOfInput; i++)
        //    {
        //        input[rightIndex] = tempInput[rightIndex];
        //        rightIndex--;
        //    }
        //}
    }
}
