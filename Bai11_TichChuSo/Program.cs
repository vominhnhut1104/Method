using System;
using System.Xml.Schema;

namespace Bai10
{
    // tinh tong cac chu so nguyen duong
    class Loop
    {
        public static int Tich(int n)
        {

            int tich = 1;
            while (n > 0)
            {

                tich = tich *( n % 10);
                n = n / 10;

            }
            return tich;
        }
        public static void Main(string[] args)
        {



            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0) Console.WriteLine("Invalid");

                else Console.WriteLine(Tich(n));

            }
        }
    }
}

