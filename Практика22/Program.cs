using System;

namespace Практика22
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine((num >= 0) ? (num <= 9) ? "Да" : "Нет" : "Нет");
        }
    }
}
