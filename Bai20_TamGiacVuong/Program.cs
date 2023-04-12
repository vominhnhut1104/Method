using System;
namespace Bai8
{


    class Loop
    {
        public static void TamGiacVuong(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {



           int h = int.Parse(Console.ReadLine());

            if (h < 0) Console.WriteLine("NO");
            else
                TamGiacVuong(h);




        }
    }
}