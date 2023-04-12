using System;
using System.Xml.Schema;

namespace Bai13_14
{
    // tinh tong cac chu so nguyen duong
    class Loop
    {
        public static void DemUocSo(int n)
        {
            int count = 0;
            for ( int i = 1; i <= n; i++ )
            {
               
                if ( n % i == 0)
                {
                    count++;
                    Console.Write(i+ " " );
                  
                }

            }
            Console.WriteLine();
            Console.WriteLine(count);


        }
        public static void Main(string[] args)
        {



            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: "); // in ra thứ tự bộ test
                if (n <= 0) Console.WriteLine("Invalid");
               else
                    DemUocSo(n);
               

            }
        }
    }
}
