using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _a_умножить_b__делить_c
{
    class Program
    {
        static float Sum(float a, float b, float c)
        {
            return (a * b)/c;
        }
        static void Main(string[] args)
        {
            float x = Sum(57, 4, 5);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
