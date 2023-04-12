using System;
using System.Xml.Schema;

namespace Bai10
{
    // tinh tong cac chu so nguyen duong
    class Loop
    {
        public static int Sum(int n)
        {

            int sum = 0;
            while (n > 0)
            {

                sum = sum + n % 10;
                n = n / 10;

            }
            return sum;
        }
        public static void Main(string[] args)
        {



            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0) Console.WriteLine("Invalid");

                else Console.WriteLine(Sum(n));

            }
        }
    }
}
