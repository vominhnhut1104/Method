using System;
using System.Xml.Schema;

namespace Bai10
{
    // tinh tong cac chu so nguyen duong
    class Loop
    {
        public static decimal SumFibonancy(int n)
        {
            decimal sum = 0;
            decimal f0 = 0;
            decimal f1 = 1;
            for (int i = 2; i<= n;i++)
            {
                sum = f0 + f1;
                f0 = f1;
                f1 = sum;
               
            }
            return sum ;
        }
        public static void Main(string[] args)
        {

            //Công thức truy hồi của dãy fibonacci có dạng: số phía sau = 2 số phía trc cộng lại, dãy này băt đầu là 2

            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    Console.WriteLine(SumFibonancy(n));

                }


            }
        }

    }
}
