using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.WeeklyContest._204
{
    class DetectPatterOfLengthMRepeatedK
    {
        public bool ContaisPattern(int[] arr, int m, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int nummatch = 1;
                int j = i + m;
                while (j + m - 1 < arr.Length)
                {
                    if (good(arr, i, j, m))
                    {
                        nummatch++;
                        j += m;
                    }
                    else
                    {
                        break;
                    }
                }
                if (nummatch >= k) return true;
            }

            return false;
        }

        bool good(int[] v, int a, int b, int k)
        {
            if (b + k - 1 >= v.Length) return false;
            for (int i = 0; i < k; i++)
            {
                if (v[a + i] != v[b + i]) return false;
            }
            return true;
        }
    };
}
