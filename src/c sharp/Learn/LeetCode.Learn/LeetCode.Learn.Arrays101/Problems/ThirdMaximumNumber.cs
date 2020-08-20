using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCode.Learn.Arrays101.Problems
{
    class ThirdMaximumNumber
    {
        public int ThirdMax(int[] numbers)
        {
            //Corner cases1
            if (numbers.Length == 1)
                return numbers[0];

            //Corner cases2
            if (numbers.Length == 2)
                return Math.Max(numbers[0], numbers[1]);

            long firstMax = Int64.MinValue;
            long secondMax = Int64.MinValue;
            long thirdMax = Int64.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == firstMax || numbers[i] == secondMax || numbers[i] == thirdMax)
                {
                    continue;
                }

                if (numbers[i] > thirdMax)
                {
                    if (numbers[i] > secondMax)
                    {
                        if (numbers[i] > firstMax)
                        {
                            thirdMax = secondMax;
                            secondMax = firstMax;
                            firstMax = numbers[i];

                            continue;
                        }

                        thirdMax = secondMax;
                        secondMax = numbers[i];
                        continue;
                    }

                    thirdMax = numbers[i];
                }
            }

            return Convert.ToInt32((thirdMax == Int64.MinValue ? firstMax : thirdMax).ToString());
        }
    }
}

