namespace LeetCode.Learn.Arrays101.Problems
{
    class SortArrayByParityProblem
    {
        //Method 1
        public int[] SortArrayByParity(int[] numbers)
        {
            if (numbers is null)
                return null;

            int evenIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    int tempNumber = numbers[evenIndex];
                    numbers[evenIndex] = numbers[i];
                    numbers[i] = tempNumber;

                    evenIndex++;
                }
            }

            return numbers;
        }

        //Method 2 :
        public int[] SortArrayByParity_Method2(int[] numbers)
        {
            if (numbers is null)
                return null;

            int reverseCount = numbers.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (reverseCount <= i)
                    break;

                if (numbers[i] % 2 == 1)
                {
                    while (numbers[reverseCount--] % 2 == 1 && reverseCount >= i) ;

                    int tempNumber = numbers[i];
                    numbers[i] = numbers[reverseCount + 1];
                    numbers[reverseCount + 1] = tempNumber;
                }
            }

            return numbers;
        }
    }
}
