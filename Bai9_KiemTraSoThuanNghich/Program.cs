using System;
using System.Xml.Schema;

namespace Bai9
{
    // kiểm tra số nguyên thuan  nghich
    class Loop
    {
        public static bool SoThuanThuanNghich(int n)
        {
            bool kq = false;
            if (n < 0)
            {
                n = Math.Abs(n);
            }

            int sothuannghich = 0;
            int m = n;

            while (m > 0)
            {
                sothuannghich = sothuannghich * 10 + m % 10;
                m = m / 10;
            }
            if (sothuannghich == n) kq = true;

            return kq;
        }
        public static void Main(string[] args)
        {



            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
               

                Console.WriteLine(SoThuanThuanNghich(n) ? "YES" : "NO");

                //cách 2 nếu dùng for 
                //int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
                //for (int i = 1; i <= t; i++)
                //{
                //    int n = int.Parse(Console.ReadLine());
                //    Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                //    if (n < 0)
                //    {
                //        n = -1 * n;
                //    }
                //    int reverse = 0;
                //    for (int value = n; value > 0; value /= 10)
                //    {
                //        reverse = reverse * 10 + value % 10;
                //    }
                //    Console.WriteLine(reverse == n ? "YES" : "NO");
                //}
            }
        }
    }
}
