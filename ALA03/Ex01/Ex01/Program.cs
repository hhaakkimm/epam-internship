using System;

namespace Ex01
{
    class Program
    {
        static void swapRows(int[,] Array, int i, int j, int m)
        {
            int[] temp = new int[m];

            for (int k = 0; k < m; k++)
            {
                temp[k] = Array[i, k];
                Array[i, k] = Array[j, k];
                Array[j, k] = temp[i];
            }
        }
        static int[,] sortsum(int[,] Array, int n, int m)
        {
            int[,] sum = new int[n, n];
            sum = Array;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j > 0)
                        sum[i, j] += sum[i, j - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (sum[i, m - 1] > sum[j, m - 1])
                    {
                        swapRows(Array, i, j, m);
                    }
                }
            }
            return (Array);
        }

        public int getMax(int[,] arr, int i, int m)
        {
            int mx = arr[i, 0];
            for (int j = 0; j < m; j++)
            {
                if (mx > arr[i, j])
                    mx = arr[i, j];
            }
            return (mx);
        }
        public int[,] sortWithMaxRow(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (getMax(arr, i, m) < getMax(arr, j, m))
                    {
                        swapRows(arr, i, j, m);
                    }
                }
            }
            return (arr);
        }


        public int getMin(int[,] arr, int i, int m)
        {
            int mn = arr[i, 0];
            for (int j = 0; j < m; j++)
            {
                if (mn < arr[i, j])
                    mn = arr[i, j];
            }
            return (mn);
        }
        public int[,] sortWithMinRow(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (getMin(arr, i, m) > getMin(arr, j, m))
                    {
                        swapRows(arr, i, j, m);
                    }
                }
            }
            return (arr);
        }
        static void Main(string[] args)
        {
            int n = 100;
            int[,] Array = new int[n, n];


        }
    }
}
