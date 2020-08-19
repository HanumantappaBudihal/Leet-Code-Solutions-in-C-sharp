using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    class ValidMountainArrayProblem
    {
        //Method1
        public bool ValidMountainArray(int[] numbers)
        {
            if (numbers is null || numbers.Length < 3)
                return false;

            bool slopePoint = false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (slopePoint == false)
                    if ((numbers[i] - numbers[i - 1]) < 0)
                    {
                        if (!slopePoint && i > 1)
                        {
                            slopePoint = true;
                            continue;
                        }

                        return false;
                    }

                if (slopePoint)
                {
                    if ((numbers[i] - numbers[i - 1]) >= 0)
                    {
                        return false;
                    }
                }
            }

            return slopePoint;
        }

        //Method 2 :
        public bool ValidMountainArray_Method2(int[] numbers)
        {
            int length = numbers.Length;
            int i = 0;

            //Walk up
            while (i + 1 < length && numbers[i] < numbers[i + 1])
                i++;

            //Peak can't be first or last
            if (i == 0 || i == length - 1)
                return false;

            //walk down
            while (i + 1 < length && numbers[i] > numbers[i + 1])
                i++;

            return i == length - 1;
        }

        //Method 3 :
        public bool ValidMountainArray_Method(int[] numbers)
        {
            var length = numbers.Length;

            if (length < 3)
                return false;

            int mountainCount = 0;

            for (int i = 1; i < length - 1; i++)
            {
                if (length > 3 && numbers[i - 1] > numbers[i] && numbers[i] < numbers[i + 1])
                {
                    mountainCount++;
                }

                if (numbers[i - 1] <= numbers[i] && numbers[i] > numbers[i + 1])
                {
                    mountainCount++;
                }
            }

            return mountainCount == 1;
        }
    }
}
