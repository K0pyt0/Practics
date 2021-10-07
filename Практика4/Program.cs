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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double ans = max(min((a + 1) / a, b), a, 2 / (a * b)) * min(a, max(0, -b, Math.Sqrt(1 + a * b))) + 2 * max(a, 3 + Math.Sqrt(a), Math.Pow(a, 3) * b);
            Console.WriteLine(ans);
        }
    }
}
