using System;

namespace Практика1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double r = 64.100;
            float p1 = 0.78932597F;
            float pr = 1e+11f;
            double f1 = 3.20000;

            decimal dec = 18500.5m;

            int s1 = 4;
            int p = 16;

            string s = "AMD";

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите дробное число: ");
            double f = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"Привет, {name}");
            Console.WriteLine("*********************************");
            Console.WriteLine("*\tЯ твой компьютер!\t*");
            Console.WriteLine("*********************************");
            Console.WriteLine("У меня следующие характеристики:");
            Console.WriteLine("");
            Console.WriteLine($"Процессор\t\t{s} с разрядностью {f1:F2}GHz");
            Console.WriteLine($"Моя память\t\t{p}Gb (доступно {p1:P0})");
            Console.WriteLine($"Жесткий диск\t\t{s1*1024:e2} Gb");
            Console.WriteLine($"Тип системы\t\t{r:F0}-разрядная ОС");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Моя производительность\t{pr:E0} оп/сек:");
            Console.WriteLine($"Индекс произв-ти\t{f:F0}");
            Console.WriteLine($"Моя стоимость\t\t{dec:C2}");
        }
    }
}