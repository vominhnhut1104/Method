using System;
namespace For
{
    class Loop
    {
        public static void SoLe(int n, int k)
        {
            for (int j = k; j <= n; j++)
            {
                if (j % 2 != 0)
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
                var data = Console.ReadLine().Split(' ');               // chuyển cách nhập xuống dòng thành nhập kế bên cách nhau bởi dấu cách
                int n = int.Parse(data[0]); // chuyển string sang số n
                int k = int.Parse(data[1]); // chuyển string sang số k
                Console.WriteLine($"Test {i} :");
                if (k > n || n <= 0)
                {
                    Console.WriteLine("NO RESULT");
                }
                
                SoLe(n, k);
                Console.WriteLine();
            }
        }
    }
}
