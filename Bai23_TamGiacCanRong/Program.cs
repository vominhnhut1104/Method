using System;
namespace Bai8
{


    class Loop
    {
        public static void TamGiacCan(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j < h * 2; j++)
                {
                    if (h - i + 1 == j || j == h + i - 1 || i == h) // i == h là in cạnh đáy, 2 biểu thức còn lại in 2 cạnh bên
                        Console.Write(" * ");
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
                TamGiacCan(h);




        }
    }
}
