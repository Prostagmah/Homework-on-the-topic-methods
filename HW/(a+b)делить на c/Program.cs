using System;

namespace _a_b_делить_на_c
{
    class Program
    {
        static int Dek(int a, int b, int c)
        {
            return (a + b)/c;
        }
        static void Main(string[] args)
        {
            int d = Dek(21, 1, 2);
            Console.Write(d);
            Console.ReadLine();
        }
    }
}