using System;
namespace Bai8
{


    class Loop
    {
        public static void HCN(int m, int n)
        {
            for ( int i = 1; i <= m; i++ )
            {
                for ( int j = 1; j <= n; j++ )
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {

           
            
                var data = Console.ReadLine().Split(' ');
                int m = int.Parse(data[0]);
                int n = int.Parse(data[1]);
                
                if ( n < 0 || m < 0) Console.WriteLine("NO");
                else
                   HCN(m, n);

                    

            
        }
    }
}

