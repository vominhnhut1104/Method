using System;

namespace Method
{
    class Program
    {
        public static void SoChan(int n)

        {
            if (n< 0)
            {
                Console.WriteLine("No Result");
            }
            for (int i = 0; i<= n; i++)
            {
                if ( i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
               
            }
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($" Test {i} :");

                SoChan(n);
                Console.WriteLine();
                
            }
        }
    }
}
