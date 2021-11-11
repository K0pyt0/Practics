using System;

namespace Практика52
{
    class Program
    {
        static string less8andOn(int N)
        {
            int count = 0;
            int tmp = 0;
            while (N > 0)
            {
                tmp = N % 10;
                if (tmp < 8)
                {
                    if (tmp % 3 != 0)
                    {
                        if (tmp % 4 != 0) count++;
                    }
                }
                N /= 10;
            }

            if (count == 0) return "NO";
            else return Convert.ToString(count);
        }

        static int EvenPairsSum(int N)
        {
            int tmp1 = 0;
            int tmp2 = 0;
            int sum = 0;
            while (N > 0)
            {
                tmp1 = N % 10;
                tmp2 = (N / 10) % 10;
                if ((tmp1 + tmp2) % 2 == 0) sum += tmp1 + tmp2;
                N /= 10;
            }
            return sum;
        }

        static string HappyNumber(int N)
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
            if (count % 2 == 0){
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
            }
            else
            {
                while (i < count / 2)
                {
                    sum1 += N % 10;
                    N = N / 10;
                    i++;
                }
                sum1 += N % 10;
                while (N > 0)
                {
                    sum2 += N % 10;
                    N = N / 10;
                }
            }

            if (sum1 == sum2) return "счастливое";
            else return "несчаcтливое";
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string ans1 = less8andOn(N);
            int ans2 = EvenPairsSum(N);
            string ans3 = HappyNumber(N);

            Console.WriteLine($"{ans1}");
            Console.WriteLine($"{ans2}");
            Console.WriteLine($"Ваше число {ans3}");
        }
    }
}
