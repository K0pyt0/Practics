using System;

namespace Практика32
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    for (int k = j + 1; k < 10; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
