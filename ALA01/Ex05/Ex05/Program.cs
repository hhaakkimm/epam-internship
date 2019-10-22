using System;

namespace Ex05
{
    class Program
    {
        static int StringToInt(string s)
        {
            int ans;

            ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ans = ans * 10 + (s[i] - '0');
            }
            return (ans);
        }

        static int getNextPermutation(string s)
        {
            int i = s.Length - 1;

            char[] array = s.ToCharArray();
            while (i > 0 && array[i - 1] >= array[i])
                i--;
            if (i <= 0)
                return StringToInt(s);

            int j = s.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            char temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;

            j = s.Length - 1;
            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            s = new String(array);
            return StringToInt(s);
        }

        static int FindNextBiggerNumber(int num)
        {
            string  s;
            int     ans;

            s = num.ToString();
            ans = getNextPermutation(s);
            return (ans);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindNextBiggerNumber(17892));
        }
    }
}
