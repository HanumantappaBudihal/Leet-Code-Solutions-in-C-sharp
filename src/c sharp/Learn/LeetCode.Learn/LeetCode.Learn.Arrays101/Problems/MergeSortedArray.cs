namespace LeetCode.Learn.Arrays101.Problems
{
    class MergeSortedArray
    {
        //Method 1
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m > 0 && n > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    int temp = nums2[0];
                    int j = 0;
                    if (nums1[i] > nums2[j])
                    {
                        nums2[j++] = nums1[i];

                        while (j < n && nums2[j] <= nums1[i])
                        {
                            int temp1 = nums2[j];
                            nums2[j] = nums2[j - 1];
                            nums2[j - 1] = temp1;
                            j++;
                        }

                        nums1[i] = temp;
                    }
                }
            }

            if (m > 0)
            {
                for (int i = m, j = 0; i < (n + m) && j < n; i++, j++)
                {
                    nums1[i] = nums2[j];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
        }
    }
}
