using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    //Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
    //Solution with best approach
    /*
     * Whichever number is present, mark that index to negative. In the end all the numbers whose missing will be having index marked as positive.
      [4,3,2,7,8,3,2,1]
      
      for (int i = 0; i < numbers.Length; i++)
      {
          var value = Math.Abs(numbers[i]) - 1;
          if (!(numbers[value] < 0))
              numbers[value] = (-1 * numbers[value]);
      }
     
     [-4,-3,-2,-7,8,3,-2,-1]
    
     As 8 and 3 are positive and they are at index 5 and 6, so the missing numbers are 5 and 6
     
     after that just get assign missing values in existing array

     int counter = 0;
     for (int i = 0; i < numbers.Length; i++)
     {
         if (numbers[i] > 0)
             numbers[counter++] = i + 1;
     }
     
     Array will have items like [5,6,-2,-7,8,3,-2,-2] , first two are expected answer
     
    return numbers.Take(counter).ToArray();

     retrun only required array
     */


    class FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var value = Math.Abs(numbers[i]) - 1;
                if (!(numbers[value] < 0))
                    numbers[value] = (-1 * numbers[value]);
            }

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    numbers[counter++] = i + 1;
            }

            return numbers.Take(counter).ToArray();
        }
    }
}
