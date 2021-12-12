
using System;

namespace Практика8{
    class Program
    {
        static int F(int n)
        {
            if (n > 30) return n * n + 5 * n + 4;
            else if (n % 2 == 0) return F(n + 1) + 3 * F(n + 4);
            else return 2 * F(n + 2) + F(n + 5);
        }

        static int DigSum(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = F(n);
            Console.WriteLine(ans);

            int count = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (DigSum(F(i)) == 27) count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
