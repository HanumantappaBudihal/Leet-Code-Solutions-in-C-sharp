using System.Collections;

namespace LeetCode.Learn.Arrays101.Problems
{
    class CheckIfNAndItsDoubleExist
    {
        //Method2
        public bool CheckIfExist_Method2(int[] numbers)
        {
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if ((i != j) && (numbers[i] == 2 * numbers[j]))
                        return true;
                }
            }

            return false;
        }

        //Method 1 
        public bool CheckIfExist(int[] numbers)
        {
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!hashtable.ContainsKey(numbers[i]))
                    hashtable.Add(numbers[i], i);                                  
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (hashtable.ContainsKey(2 * numbers[i]))
                {
                    if (hashtable[2 * numbers[i]].ToString() != i.ToString())
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }       
    }
}
