using System;

namespace Практика4
{
    class Program
    {
        static double min(double a, double b)
        {
            if (a < b) return a;
            else return b;
        }

        static double max(double a, double b, double c)
        {
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double ans = max(min((a + 1.0) / a, b), a, 2.0 / (a * b)) * min(a, max(0, -b, Math.Sqrt(1.0 + a * b))) + 2.0 * max(a, 3.0 + Math.Sqrt(a), Math.Pow(a, 3.0) * b);
            Console.WriteLine(ans);
        }
    }
}
