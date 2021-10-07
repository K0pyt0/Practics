using System;

namespace Практика32
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    for (int k = j + 1; k < 9; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
