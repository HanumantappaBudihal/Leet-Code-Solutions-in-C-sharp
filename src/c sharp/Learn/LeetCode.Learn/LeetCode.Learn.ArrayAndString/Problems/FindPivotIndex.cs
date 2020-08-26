namespace LeetCode.Learn.ArrayAndString.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
    //Solution :  https://leetcode.com/submissions/detail/386845782/
    class FindPivotIndex
    {
        public int PivotIndex(int[] numbers)
        {
            if (numbers is null)
                return -1;

            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
            }

            int leftSideSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSideSum = (totalSum - leftSideSum - numbers[i]);

                if (rightSideSum == leftSideSum)
                {
                    return i;
                }

                leftSideSum = leftSideSum + numbers[i];
            }

            return -1;
        }
    }
}
