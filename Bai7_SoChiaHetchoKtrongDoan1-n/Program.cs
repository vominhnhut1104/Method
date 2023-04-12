using System;
using System.Globalization;

namespace Bai7
{
    class For
    {
        public static void SoChiak(int n , int k)
        {

            for (int j = 1; j <= n; j++)
            {
                if (j % k == 0)
                {
                    Console.Write(j + " ");
                }

            }
            
        }
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());


            for (int i = 1; i <= t; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int k = int.Parse(data[1]);
                Console.WriteLine($"Test {i} :");

                if (n <= 0 || k <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else

                {

                    SoChiak(n,k);
                    Console.WriteLine();

                }
            }


        }
    }
}