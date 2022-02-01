using System;

namespace a_в_степени__a___b
{
    class Program
    {
        static double Sum(double b)
        {
            double x = 2;

            return (Math.Pow(x, 2) + b);
        }
        static void Main(string[] args)
        {
            double x = Sum(5);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
