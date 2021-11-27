using System;

namespace Практика7
{
    class MainClass
    {
        static int Def(int b)
        {
            int count = 0;
            while (b > 0)
            {
                count++;
                b /= 10;
            }
            return count;
        }

        static void Incr(ref int a, int b)
        {
            for (int i = 0; i < b; i++) a *= 10;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Ввелите 2 числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            b = Def(b);
            Incr(ref a, b);
            Console.WriteLine($"{a}, {b}");
        }
    }
}
