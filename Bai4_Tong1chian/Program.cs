using System;
using System.Globalization;

namespace Bai3
{
    class For
    {
        public static double Sum(int n)
        {
            double sum = 0; // đặt sum = 0 ở đây mà ko đặt ở trên là để kết quả ko bị cộng tiếp sum của test trc 
            for (int j = 1; j <= n; j++)
            {
                sum = sum + (1.0f / j);

            }
            return sum;
        }  
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());


            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i} :");

                if (n <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else
                {
                        Console.WriteLine($"{Sum(n):F3}");
                    }
                }
                
            }


        }
    }



