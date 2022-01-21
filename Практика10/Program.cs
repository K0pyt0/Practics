using System;

namespace Практика10
{
    class MainClass
    {
        static int DigSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static int FindDel(int num)
        {
            int count = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) count++;
            }
            return count;
        }

        static void Func1(out int min, out int count)
        {
            min = 12001;
            count = 0;
            for(int i = 1200; i <= 11200; i++)
            {
                if(i % 5 == 0 && i % 7 != 0 && i % 13 != 0 && i % 17 != 0 && i % 19 != 0)
                {
                    count++;
                    if (i < min) min = i;
                }
            }
        }

        static void Func2(out int max, out int count)
        {
            max = -1;
            count = 0;
            for(int i = 1; i <= 12; i++)
            {
                if(i % 6 != i % 2 && (i % 9 == 0 || i % 10 == 0 || i % 11 == 0))
                {
                    if (i > max) max = i;
                    count++;
                }
            }
        }

        static void Func3(out int avg, out int count)
        {
            int max = 0;
            int min = 2477;
            count = 0;
            for (int i = 2476; i <= 7857; i++)
            {
                if(i % 2 == 0 && i % 8 != 0 && (i / 100) % 10 < 8)
                {
                    if (max < i) max = i;
                    if (min > i) min = i;
                    count++;
                }
            }
            avg = (min + max) / 2;
        }


        static void Func4(out int ans, out int count)
        {
            count = 0;
            ans = 0;
            for (int i = 2894; i <= 174882; i++)
            {
                if (DigSum(i) > 22 && i % 10 == 8)
                {
                    count++;
                    if (count == 13) ans = i;
                }
            }
        }

        static void Func5(out int min, out int count)
        {
            min = 64355;
            count = 0;
            for (int i = 23561; i <= 64354; i++)
            {
                if(FindDel(i) >= 20)
                {
                    count++;
                    if (i < min) min = i;
                }
            }
        }

        public static void Main(string[] args)
        {
            int count, added;
            Console.WriteLine("Второй вариант");
            Console.WriteLine();

            Console.WriteLine("Первая задача");
            Func1(out added, out count);
            Console.WriteLine($"Количество чисел: {count}");
            Console.WriteLine($"Минимальное число: {added}");
            Console.WriteLine();

            Console.WriteLine("Вторая задача:");
            Func2(out added, out count);
            Console.WriteLine($"Количество чисел: {count}");
            Console.WriteLine($"Максимальное число: {added}");
            Console.WriteLine();

            Console.WriteLine("Третья задача:");
            Func3(out added, out count);
            Console.WriteLine($"Количество чисел: {count}");
            Console.WriteLine($"Среднее значение: {added}");
            Console.WriteLine();


            Console.WriteLine("Четвёртая задача:");
            Func4(out added, out count);
            Console.WriteLine($"Количество чисел: {count}");
            Console.WriteLine($"Тринадцатое число: {added}");
            Console.WriteLine();


            Console.WriteLine("Пятая задача:");
            Func5(out added, out count);
            Console.WriteLine($"Количество чисел: {count}");
            Console.WriteLine($"Минимальное число: {added}");

            Console.ReadKey();
        }
    }
}
