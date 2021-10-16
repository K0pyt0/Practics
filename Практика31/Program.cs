using System;

namespace Практика31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t");
            for (int j = 2; j < 10; j++)
            {
                Console.Write($"{j}\t");
            }

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
            }
        }
    }
}
