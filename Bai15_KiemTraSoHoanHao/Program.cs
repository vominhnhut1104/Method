using System;
namespace Bai8
{
    // kiểm tra số nguyên tố

    class Loop
    {
        public static bool SoHoanHao(int n)
        {
            bool kq = false;

            int sum = 0;
            for (int j = 1; j <  n; j++)
            {
                if (n % j == 0)
                {
                    sum = sum + j;
                }
            }
            if (sum == n )
                return true;
            return kq;

        }
        public static void Main(string[] args)
        {
          
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n == 1 || n < 0) Console.WriteLine("NO");
                else
                Console.WriteLine(SoHoanHao(n) ? "YES" : "NO");

            }
        }
    }
}
