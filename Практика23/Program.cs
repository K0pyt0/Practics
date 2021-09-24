using System;

namespace Практика23
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            switch(Math.Sign(b * b - 4 * a * c))
            {
                case 1:
                    Console.WriteLine($"Уравнение с коэффициентами {a}, {b}, {c} имеет два корня");
                    break;

                case 0:
                    Console.WriteLine($"Уравнение с коэффициентами {a}, {b}, {c} имеет один корень");
                    break;

                case -1:
                    Console.WriteLine($"Уравнение с коэффициентами {a}, {b}, {c} не имеет корней");
                    break;

                default:
                    Console.WriteLine($"КАК?");
                    break;
            }
        }
    }
}
