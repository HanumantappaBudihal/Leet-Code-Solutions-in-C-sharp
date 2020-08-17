namespace LeetCode.Learn.Arrays101.Problems
{
    //Problem statement : https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/
    class FindNumbersWithEvenNumberOfDigits
    {
        //Method 1 : Use the build ToString() method and find the lenght
        //public int FindNumbers(int[] nums)
        //{
        //    int numberOfEvenDigitsNumbers = 0;
        //    int length = nums.Length;

        //    for (int iterator = 0; iterator < length; iterator++)
        //    {
        //        if (nums[iterator].ToString().Length % 2 == 0)
        //            numberOfEvenDigitsNumbers++;
        //    }

        //    return numberOfEvenDigitsNumbers;
        //}

        //Method 2 : Write the method to calculate the digits of numbers and find out the even of add
        // Run : 90.3% better Memory :
        public int FindNumbers(int[] nums)
        {
            int numberOfEvenDigitsNumbers = 0;
            int length = nums.Length;

            for (int iterator = 0; iterator < length; iterator++)
            {
                if (GetNumberOfDigits(nums[iterator]) % 2 == 0)
                    numberOfEvenDigitsNumbers++;
            }

            return numberOfEvenDigitsNumbers;
        }

        public int GetNumberOfDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result++;
                number = number / 10;
            }

            return result;
        }
    }
}
