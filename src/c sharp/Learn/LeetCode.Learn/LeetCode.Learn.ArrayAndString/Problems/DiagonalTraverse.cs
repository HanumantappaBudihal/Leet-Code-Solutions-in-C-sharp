using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.ArrayAndString.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
    //Solution : 
    class DiagonalTraverse
    {
        //TODO : Need to complete the implementation part
        public int[] FindDiagonalOrder(int[,] matrix)
        {
            var dictionary = new Dictionary<int, List<int>>();
            int indexSum = 0;
            for (int i = 0; i < matrix.GetUpperBound(0); i++)
            {
                indexSum = i;
                for (int j = 0; j < matrix.GetUpperBound(1); j++)
                {
                    indexSum += j;

                    if (dictionary.ContainsKey(indexSum))
                    {
                        dictionary[indexSum].Add(matrix[i, j]);
                    }
                    else
                    {
                        var newList = new List<int>();
                        newList.Add(matrix[i, j]);
                        dictionary.Add(indexSum, newList);
                    }
                }
            }
            
            var result = dictionary.Values;

            return null;
        }
    }
}
