using System;
namespace Bai8
{


    class Loop
    {
        public static void HV(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n || i == j || j + i == n+1)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {



           
            int n = int.Parse(Console.ReadLine());

            if (n < 0 ) Console.WriteLine("NO");
            else
                HV(n);

        }
    }
}