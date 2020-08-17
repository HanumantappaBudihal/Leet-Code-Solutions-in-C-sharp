using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
    class DuplicateZerosProblem
    {
        //Method 1 
        public void DuplicateZeros(int[] arr)
        {
            if (arr is null)
                return;

            int[] tempArray = new int[arr.Length];
            int lenght = arr.Length;

            for (int i = 0, j = 0; i < lenght && j < lenght; i++, j++)
            {
                if (arr[i] == 0)
                {
                    j++;
                }
                else
                {
                    tempArray[j] = arr[i];
                }
            }

            for (int i = 0; i < lenght; i++)
            {
                arr[i] = tempArray[i];
            }
        }

        //TODO : 
        //Method 2 : Better solution : Still need to work out

        //public void DuplicateZeros(int[] arr)
        //{
        //    int possiableZeros = 0;
        //    int lenght = arr.Length - 1;

        //    //Find the number of zeros to be duplicated
        //    //Stopping when left points beyond the last element in the original array
        //    for (int leftIndex = 0; leftIndex <= (lenght - possiableZeros); leftIndex++)
        //    {
        //        if (arr[leftIndex] == 0)
        //        {
        //            //Let's handle the edge cases 
        //            if (leftIndex == (lenght - possiableZeros))
        //            {
        //                arr[lenght] = 0;                     
        //                break;
        //            }

        //            possiableZeros++;
        //        }
        //    }

        //    //Start backward from the last element which would be part of new array
        //    // Very imp assignment
        //    int lastIndex = lenght - possiableZeros;
        //    for (int i = lastIndex; i >= 0; i--)
        //    {
        //        if (arr[i] == 0)
        //        {
        //            arr[i + possiableZeros] = 0;
        //            possiableZeros--;
        //            if (possiableZeros < 0)
        //                break;

        //            arr[i + possiableZeros] = 0;
        //        }
        //        else
        //        {
        //            arr[i + possiableZeros] = arr[i];
        //        }
        //    }
        //}
    }
}
