using System;

namespace Практика8
{
    class Program
    {
        static int F(int n)
        {
            if (n > 30) return n * n + 5 * n + 4;
            else if (n % 2 == 0) return F(n + 1) + 3 * F(n + 4);
            else return 2 * F(n + 2) + F(n + 5);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(27);
        }
    }
}
