using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    //Problem statement :  https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
    class RemoveElementProblem
    {
        //Method 1 :
        public int RemoveElement(int[] nums, int val)
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
