using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace корень_из_a_в_квадрате___b_в_квадрате___c
{
    class Program
    {

        static double Sum(double c)
        {
            double x = 2;
            double z = 1;
            
            return (Math.Pow(x, 2) + (Math.Pow(z, 2) +c));
        }

        static void Main(string[] args)
        {
            Math.Sqrt(Sum(4));
            double v  = Convert.ToInt32(Math.Sqrt(Sum(4)));
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
