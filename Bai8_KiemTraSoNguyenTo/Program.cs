using System;
namespace Bai8
{
    // kiểm tra số nguyên tố
   
    class Loop
    {
        public static bool SoNguyenTo(int n)
        {
            bool kq = true;
            if (n < 2)
            {
                kq = false;
            }
            double k = Convert.ToDouble(Math.Sqrt(n));
            for (int j = 2; j <= k; j++)
            {
                if (n % j == 0)
                {
                    kq = false;
                }
            }
            return kq;

        }
        public static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine()); 

            //for (int i = 1; i <= t; i++) 
            //{ 
            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Test {i}");


            //        if (n == 1 || n< 0 ) Console.WriteLine("NO");
            //        else if (n % 1 == 0 && n % n == 0) 
            //        Console.WriteLine("Yes");
            //        else
            //            Console.WriteLine("NO");


            //}

            //Cách 2
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
               
                Console.WriteLine(SoNguyenTo(n) ? "YES" : "NO");

            }
        }
    }
}
