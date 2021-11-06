using System;

namespace Practics53
{
    class Program
    {
        static int find_del_sum(int N)
        {
            int sum = 0;
            for (int i = 1; i < N / 2 + 1; i++)
            {
                if (N % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i ++)
            {
                if (find_del_sum(i) == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
