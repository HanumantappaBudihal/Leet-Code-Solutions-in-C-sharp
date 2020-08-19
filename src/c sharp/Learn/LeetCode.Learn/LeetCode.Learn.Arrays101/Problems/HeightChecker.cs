using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    class HeightCheckerProblem
    {
        public int HeightChecker(int[] heights)
        {
            int lenght = heights.Length;
            var newArray = heights.ToList();
            newArray.Sort();
            int swapCount = 0;
            for(int i=0; i < lenght;i++)
            {
                if (heights[i] != newArray[i])
                    swapCount++;
            }

            return swapCount;
        }
    }
}
