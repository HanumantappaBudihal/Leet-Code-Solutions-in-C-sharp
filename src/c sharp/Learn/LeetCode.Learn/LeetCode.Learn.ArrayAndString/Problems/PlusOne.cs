using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Learn.ArrayAndString.Problems
{
    //Problem statement :  https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1148/
    //Solution : https://leetcode.com/submissions/detail/386863319/ ( beats 99.76 % run time)
    class PlusOneProblem
    {
        public int[] PlusOne(int[] digits)
        {
            int carry = 1;
            int lenght = digits.Length;

            if ((digits[lenght - 1] + carry) <= 9)
            {
                digits[lenght - 1] = digits[lenght - 1] + carry;
                return digits;
            }

            lenght = lenght - 1;
            while (carry == 1 && lenght >= 0)
            {
                digits[lenght] = digits[lenght] + carry;

                if (digits[lenght] > 9)
                {
                    carry = 1;
                    digits[lenght] = 0;
                }
                else
                {
                    carry = 0;
                }

                lenght--;
            }

            if (carry == 1)
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;

                for (int i = 1; i < digits.Length + 1; i++)
                {
                    newDigits[i] = digits[i - 1];
                }

                return newDigits;
            }

            return digits;
        }
    }
}
