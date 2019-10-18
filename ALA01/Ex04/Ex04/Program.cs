using System;

namespace Ex04
{
    class Program
    {
        public static bool isLower(char s)
        {
            if (s >= 'a' && s <= 'z')
                return (true);
            return (false);
        }

        public static string concatStr(string first, string second)
        {
            string  ans;
            int     index;
            bool[]  used = new bool[55]; // quantity of alphabetic symbols (lower + upper cases), it's already filled with 0

            ans = "";
            for (int i = 0; i < first.Length; i++)
            {
                index = 54;
                if (isLower(first[i]) && !used[first[i] - 'a'])
                {
                    ans += first[i];
                    index = first[i] - 'a';
                }
                if (!isLower(first[i]) && !used[first[i] - 'A' + 26])
                {
                    ans += first[i];
                    index = first[i] - 'A' + 26;
                }
                used[index] = true;
            }
            for (int i = 0; i < second.Length; i++)
            {
                index = 54;
                if (isLower(second[i]) && !used[second[i] - 'a'])
                {
                    ans += second[i];
                    index = second[i] - 'a';
                }
                if (!isLower(second[i]) && !used[second[i] - 'A' + 26])
                {
                    ans += second[i];
                    index = second[i] - 'A' + 26;
                }
                used[index] = true;
            }
            return (ans);
        }
        //Shortened
        public static string uniteStr(string a, string b)
        {
            bool[]  used = new bool[128]; // ascii size;
            string  ans;

            ans = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (!used[(int)a[i]])
                    ans += a[i];
                used[(int)a[i]] = true;
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (!used[(int)b[i]])
                    ans += b[i];
                used[(int)b[i]] = true;
            }
            return (ans);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(concatStr("Hakeem", "EpamInternship"));
            Console.WriteLine(uniteStr("Hakeem", "EpamInternship"));
        }
    }
}
