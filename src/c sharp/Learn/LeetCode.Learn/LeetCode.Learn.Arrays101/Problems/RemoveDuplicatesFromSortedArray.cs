namespace LeetCode.Learn.Arrays101.Problems
{
    class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums is null || nums.Length <= 0)
                return 0;

            int duplicateItem = nums[0];
            int newLength = 1;
            int length = nums.Length;

            for (int i = 1; i < (length); i++)
            {
                while(true)
                {
                    if (duplicateItem != nums[i])
                    {
                        nums[newLength++] = nums[i];
                        duplicateItem = nums[i];
                        break;
                    }

                    i++;
                }                
            }

            return newLength;
        }
    }
}
