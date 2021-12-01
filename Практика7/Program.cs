using System;

namespace Практика7
{
    class MainClass
    {
        static int Def(int b)
        {
            int count = 0;
            while (b > 9)
            {
                count++;
                b /= 10;
            }
            return count;
        }

        static void Incr(ref int a, int b)
        {
            for (int i = 0; i < Def(b); i++) a *= 10;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Incr(ref a, b);
            Console.WriteLine($"{a}");
        }
    }
}
