using System;

namespace Method
{
    class Program
    {
        public static double Circumference( double r )
        {
            return  r * 2 * 3.14;
            

        }

        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Circumference(r));
        }
    }
}
