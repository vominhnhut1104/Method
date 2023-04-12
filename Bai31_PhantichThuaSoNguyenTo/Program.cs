using System;
namespace SoNguyenTo
{
    class Phantich
    {
        public static void PhantichThuaSoNT(int n)
        {
            
            for (int i = 2; i <= n; i++)
            {
                int dem = 0;
                while (n % i == 0)
                {
                    dem++;
                    n = n / i;
                }
                if (dem != 0)
                {
                    Console.Write(i);
                    if (dem > 1) Console.Write($"^ {i}");// cộng i hay dem đều dcc vì trong hàm while cả 2 đều tăng cùng lúc
                    if (n > i)
                    {
                        Console.Write("*");
                    }
                }



            }
        }
        
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

        PhantichThuaSoNT(n);



        }
    }
}
