namespace LeetCode.Learn.Arrays101.Problems
{
    //Problem references : https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/
    class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] numbers)
        {
            int maximumConsecutiveLength = 0;
            int length = numbers.Length;

            //If numbers is null
            if (numbers is null)
                return 0;

            int onesCount = 0;
            for (int iterator = 0; iterator < length; iterator++)
            {
                if (numbers[iterator] == 1)
                {
                    onesCount++;
                }
                else
                {
                    if (onesCount > maximumConsecutiveLength)
                        maximumConsecutiveLength = onesCount;
                    onesCount = 0;
                }
            }

            if (onesCount > maximumConsecutiveLength)
                return onesCount;

            return maximumConsecutiveLength;
        }
    }
}
