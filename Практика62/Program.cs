using System;

namespace Практика62
{
    class MainClass
    {
        static void Num1()
        {            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            X >>= N;
            if ((X & 0x0001) == 0x0001) Console.WriteLine(1);
            else Console.WriteLine(0);
        }

        static void Num2()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 31; i >= 0; i--)
            {
                Console.Write((N >> i) & 0x0001);
            }
        }

        public static void Main(string[] args)
        {
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1) Num1();
            else Num2();
        }
    }
}
