using System;

namespace Практика7
{
    class MainClass
    {
        static void PlusMinus(ref int a, ref int b)
        {
            a = a + b;
            b = a - b - b;

        }

        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            PlusMinus(ref a, ref b);
            Console.WriteLine($"{a}, {b}");
        }
    }
}
