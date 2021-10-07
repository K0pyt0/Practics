using System;

namespace Практика33
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int max = 0;
            int inp = int.Parse(Console.ReadLine());
            while (inp != -1)
            {
                switch (inp)
                {
                    case 0:
                        if (count > max) max = count; 
                        count = 0;
                        break;
                    case 1:
                        count++;
                        break;
                    default:
                        Console.WriteLine("Wait. It's illegal");
                        break;
                }
                inp = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(max);
        }
    }
}
