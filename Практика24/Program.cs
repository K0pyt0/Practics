using System;

namespace Практика24
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(a == b? a == c? b == c? "Yes" : "Yes" : "Yes" :"No");
        }
    }
}
