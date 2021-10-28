using System;

namespace Практика52
{
    class Program
    {
        static void Main(string[] args)
        {
            static string N1(int N)
            {
                int count = 0;
                int tmp = 0;
                while (N > 0)
                {
                    tmp = N % 10;
                    if (tmp < 8 && tmp % 3 != 0 && tmp % 4 != 0) count++;
                    N = N / 10;
                }

                if (count == 0) return "NO";
                else return Convert.ToString(count);
            }

            static int N2(int N)
            {
                int tmp1 = 0;
                int tmp2 = 0;
                int sum = 0;
                while (N > 0)
                {
                    tmp1 = N % 10;
                    tmp2 = (N / 10) % 10;
                    if ((tmp1 + tmp2) % 2 == 0) sum += tmp1 + tmp2;
                }
                return sum;
            }

            static bool N3(int N)
            {
                int tmpN = N;
                int count = 0;
                while (tmpN > 0)
                {
                    count++;
                    tmpN = tmpN / 10;
                }

                int sum1 = 0;
                int sum2 = 0;
                int i = 0;
                while (i < count / 2)
                {
                    sum1 += N % 10;
                    N = N / 10;
                    i++;
                }
                while (N > 0)
                {
                    sum2 += N % 10;
                    N = N / 10;
                }

                if (sum1 == sum2) return true;
                else return false;
            }

            static void Main(string[] args)
            {
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine($"{N}");
                Console.WriteLine(N1(N));
                Console.WriteLine($"{N2(N)}");
                Console.WriteLine($"{N3(N)}");
            }
        }
    }
}
