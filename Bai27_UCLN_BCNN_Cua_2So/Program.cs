using System;
namespace Bai27
{


    class Loop
    {
        public static int UCLN(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                return 0;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;

                }
                if (b > a)
                {
                    b = b - a;

                }

            }
           return a;
            
        }
       public static double BCNN(int a, int b)
        {
           int x = UCLN (a, b); // phải gọi Phương thức trên truyền biến thì mới dùng dc
            if (x == 0)
             return 0;
           else 
                return (a*b)/x;

        }
        public static void Main(string[] args)
        {



            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            Console.WriteLine(UCLN(a, b));
            Console.WriteLine(BCNN(a, b));


        }
    }
}

