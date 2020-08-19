namespace LeetCode.Learn.Arrays101.Problems
{
    class RemoveDuplicatesFromSortedArray
    {
        //Method 1 :
        public int RemoveDuplicates(int[] numbers)
        {
            if (numbers is null || numbers.Length <= 0)
                return 0;

            int duplicateItem = numbers[0];
            int newLength = 1;
            int length = numbers.Length;

            for (int i = 1; i < (length); i++)
            {
                while (true)
                {
                    if (duplicateItem != numbers[i])
                    {
                        numbers[newLength++] = numbers[i];
                        duplicateItem = numbers[i];
                        break;
                    }

                    i++;
                }
            }

            return newLength;
        }

        //Method 2 :
        public int RemoveDuplicates_Method2(int[] numbers)
        {
            int length = numbers.Length;
            if (length == 0) return 0;

            int count = 0;
            for (int i = 1; i < length; i++)
            {
                if (numbers[i] != numbers[count])
                {
                    count++;
                    numbers[count] = numbers[i];
                }
            }

            for (int i = count + 1; i < length; i++)
            {
                numbers[i] = 0;
            }

            return count + 1;
        }
    }
}
