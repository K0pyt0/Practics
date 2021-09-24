using System;

namespace Практика2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 0) Console.WriteLine("Не бей по своим");
            else if (num <= 28) Console.WriteLine("НЕДОЛЁТ");
            else if (num < 30) Console.WriteLine("ПОПАЛ!");
            else Console.WriteLine("ПЕРЕЛЁТ");
        }
    }
}
