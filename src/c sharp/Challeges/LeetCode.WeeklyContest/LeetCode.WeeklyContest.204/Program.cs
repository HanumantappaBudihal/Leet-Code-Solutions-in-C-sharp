using System;

namespace LeetCode.WeeklyContest._204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1.DetectPatterOfLengthMRepeatedK
            DetectPatterOfLengthMRepeatedK_Main();

            //2.MaximumLengtOfSubarrayWithPositiveProduct
            //MaximumLengtOfSubarrayWithPositiveProduct_Main();
        }

        private static void MaximumLengtOfSubarrayWithPositiveProduct_Main()
        {
            MaximumLengtOfSubarrayWithPositiveProduct maximumLengtOfSubarrayWithPositiveProduct = new MaximumLengtOfSubarrayWithPositiveProduct();
            int[] arr = { 1, -2, -3, 4 };

            var result = maximumLengtOfSubarrayWithPositiveProduct.GetMaxLen(arr);
        }

        private static void DetectPatterOfLengthMRepeatedK_Main()
        {
            DetectPatterOfLengthMRepeatedK detectPatterOfLengthMRepeatedK = new DetectPatterOfLengthMRepeatedK();
            int[] inputArray = new int[] { 1, 2, 4, 4, 4, 4 };
            int m = 1;
            int k = 3;

            var result = detectPatterOfLengthMRepeatedK.ContaisPattern(inputArray, m, k);
        }
    }
}
