namespace LeetCode.WeeklyContest._204
{
    // Problem Link : https://leetcode.com/contest/weekly-contest-204/problems/maximum-length-of-subarray-with-positive-product/
    class MaximumLengtOfSubarrayWithPositiveProduct
    {

        static int min(int x, int y) { return x < y ? x : y; }
        static int max(int x, int y) { return x > y ? x : y; }       
        public int GetMaxLen(int[] nums)
        {
            int numberCount = 0;
            int n = nums.Length;
            int max_ending_here = 1;
            int min_ending_here = 1;

            // Initialize overall max product 
            int max_so_far = 1;
            int flag = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    max_ending_here = max_ending_here * nums[i];
                    min_ending_here = min(min_ending_here * nums[i], 1);

                    flag = 1;
                }

                else if (nums[i] == 0)
                {
                    max_ending_here = 1;
                    min_ending_here = 1;
                }
                else
                {
                    int temp = max_ending_here;
                    max_ending_here = max(min_ending_here * nums[i], 1);
                    min_ending_here = temp * nums[i];
                }

                if (nums[i] == 1 && max_so_far == max_ending_here)
                {
                    numberCount++;
                }
                // update max_so_far, if needed 
                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    numberCount++;
                }
            }

            if (flag == 0 && max_so_far == 1)
                return 0;

            return numberCount;
        }
    }
}

