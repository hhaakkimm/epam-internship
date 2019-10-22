using System;
using System.Collections;

namespace Ex06
{
    class Program
    {
        static bool check(int x, int digit)
        {
            while (x > 0)
            {
                if (x % 10 == digit)
                    return (true);
                x /= 10;
            }
            return (false);
        }
        static ArrayList FilterDigit(int[] Array, int digit)
        {
            ArrayList ans = new ArrayList();

            for (int i = 0; i < Array.Length; i++)
            {
                if (check(Array[i], digit))
                    ans.Add(Array[i]);
            }
            return (ans);
        }
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();
            int[] Array = {7,1,2,3,4,5,6,7,68,69,70, 15,17};
            nums = FilterDigit(Array, 7);

            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
