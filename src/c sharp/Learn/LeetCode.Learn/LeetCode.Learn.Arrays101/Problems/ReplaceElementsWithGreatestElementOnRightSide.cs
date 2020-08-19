namespace LeetCode.Learn.Arrays101.Problems
{
    class ReplaceElementsWithGreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] numbers)
        {
            if (numbers is null)
                return numbers;

            //Edge case
            if (numbers.Length == 1)
            {
                numbers[0] = -1;
                return numbers;
            }

            int length = numbers.Length;
            int maximumElement = numbers[length - 1];

            //set the last element value to -1
            numbers[length - 1] = -1;

            for (int i = length - 2; i >= 0; i--)
            {
                int tempMaximumElement = numbers[i];
                numbers[i] = maximumElement;
                if (maximumElement < tempMaximumElement)
                    maximumElement = tempMaximumElement;
            }

            return numbers;
        }
    }
}
