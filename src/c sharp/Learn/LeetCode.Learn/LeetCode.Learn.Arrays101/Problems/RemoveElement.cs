using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    //Problem statement :  https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
    class RemoveElementProblem
    {
        //Method2 : Better performance
        public int RemoveElement(int[] nums, int val)
        {
            int n = nums.Length;
            int i, j, x;
            for (i = 0; i < n; i++)
            {
                if (nums[i] == val)
                {
                    for (j = n - 1; j > i; j--)
                    {
                        if (nums[j] != val) break;
                    }
                    if (i == j) break;
                    else
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return i;
        }

        public int RemoveElement_Method2(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    // reduce array size by one
                    n--;
                }
                else
                {
                    i++;
                }
            }

            return n;
        }

        //Method 1 : Even mainted the order here ( excluding the item from list, but maintained the order)
        public int RemoveElement_Method1(int[] nums, int val)
        {
            if (nums is null)
                return 0;

            int newLength = 0;

            //Find out the new length
            newLength = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                    newLength--;
            }


            int valCount = 0;
            for (int i = 0; i < newLength; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i + 1; j < newLength; j++)
                    {
                        if (nums[j] != val)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;

                            break;
                        }
                    }
                }
            }

            // Figure out how may val within in newLength
            for (int i = 0; i < newLength; i++)
            {
                if (nums[i] == val)
                {
                    valCount++;
                }
            }

            //Now shift the character ( swaping)
            for (int i = newLength; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[newLength - (valCount--)] = nums[i];
                }
            }

            return newLength;
        }
    }
}
