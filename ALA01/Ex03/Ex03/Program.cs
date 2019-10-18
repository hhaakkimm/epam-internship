using System;

namespace Ex03
{
    class Program
    {
        public static int findPivot(int[] Array, int size)
        {
            int[] d = new int[size + 5];

            for (int i = 0; i < d.Length; i++)
                d[i] = 0;
            for (int i = 0; i < size; i++)
            {
                d[i] = Array[i];
                if (i > 0)
                    d[i] += d[i - 1];
            }
            for (int i = 1; i < size; i++)
            {
                if (d[i - 1] == d[size - 1] - d[i])
                    return (i + 1);
            }
            return (-1);
        }
        static void Main(string[] args)
        {
            int[] Array = { 1, -1, 4, 99, 2, 2};
            int size = Array.Length;
            Console.WriteLine(findPivot(Array, size));
        }
    }
}
