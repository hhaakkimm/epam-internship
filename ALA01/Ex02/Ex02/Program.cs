using System;

namespace Ex02
{
    class Program
    {
        public static int getMax(int a, int b)
        {
            return (a > b ? a : b);
        }

        public static int maxRec(int n, int[] Array)
        {
            if (n == 1)
                return (Array[0]);
            return getMax(Array[n - 1], maxRec(n - 1, Array));
        }
        static void Main(string[] args)
        {
            int[] Array = {1, 5, -7, 5, 3, 99, 0};
            int size = Array.Length;
            Console.WriteLine(maxRec(size, Array));
        }
    }
}
