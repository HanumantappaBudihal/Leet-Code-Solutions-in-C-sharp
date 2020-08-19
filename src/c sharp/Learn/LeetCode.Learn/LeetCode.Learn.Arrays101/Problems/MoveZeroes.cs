using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Learn.Arrays101.Problems
{
    class MoveZeroesProblem
    {
        public void MoveZeroes(int[] numbers)
        {
            if (numbers is null)
                return;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    numbers[count++] = numbers[i];
                }
            }

            for (int i = count; i < numbers.Length; i++)
                numbers[i] = 0;
        }
    }
}
