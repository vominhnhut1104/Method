
using System;
namespace Bai8
{


    class Loop
    {
        public static void TamGiacCanSoDoiXung(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < h * 2; j++)
                {
                    if (h - i + 1 <= j && j <= h + i - 1)
                        Console.Write($" {i - Math.Abs(h-j)} ");
                    else
                        Console.Write("   ");
                }


                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {



            int h = int.Parse(Console.ReadLine());

            if (h < 0) Console.WriteLine("NO");
            else
                TamGiacCanSoDoiXung(h);




        }
    }
}