using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.ArrayAndString.Problems
{
    class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> spiralList = new List<int>();
            int k = 0;
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetLongLength(0); j++)
                {
                    k++;
                    Console.Write(" " + k);
                }

                Console.WriteLine();
            }


            return spiralList.ToArray();
        }
    }
}
