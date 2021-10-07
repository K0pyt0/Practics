using System;

namespace Практика3BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i++)
            {
                for(int j  = 2; j < 10; j++)
                {
                    Console.Write($"{j} x {i} = {j*i}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
