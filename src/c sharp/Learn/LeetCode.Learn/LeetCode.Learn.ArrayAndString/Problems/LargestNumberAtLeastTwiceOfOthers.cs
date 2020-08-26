using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.ArrayAndString.Problems
{
    //Problem statement :https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1147/
    // Solution : https://leetcode.com/submissions/detail/386852249/
    class LargestNumberAtLeastTwiceOfOthers
    {
        public int DominantIndex(int[] numbers)
        {
            //First iteration , find out the biggest number

            int maxIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[maxIndex] < numbers[i])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == maxIndex)
                    continue;

                if (numbers[maxIndex] < (2 * numbers[i]))
                    return -1;
            }

            return maxIndex;
        }
    }
}
