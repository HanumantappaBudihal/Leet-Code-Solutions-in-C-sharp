using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Learn.ArrayAndString.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
    //Solution : 
    class DiagonalTraverse
    {
        //TODO : Need to complete the implementation part
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            var dictionary = new Dictionary<int, List<int>>();
            int indexSum = 0;

            //for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            int i = 0;
            foreach (var item in matrix)
            {
                indexSum = i;
                int j = 0;
                foreach (var items in item)
                {
                    indexSum = i + j;

                    if (dictionary.ContainsKey(indexSum))
                    {
                        dictionary[indexSum].Add(items);
                    }
                    else
                    {
                        var newList = new List<int>();
                        newList.Add(items);
                        dictionary.Add(indexSum, newList);
                    }

                    j++;
                }

                i++;
            }

            List<int> result = new List<int>();

            int counter = 0;
            foreach (var item in dictionary)
            {
                var elements = item.Value.ToList();
                if ((counter % 2) == 0)
                    elements.Reverse();

                result.AddRange(elements);

                counter++;
            }

            return result.ToArray();
        }
    }
}
