using System;

namespace Практика31
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t");
                    if (i == 1) if (j == 1) continue;
                    Console.Write(i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
