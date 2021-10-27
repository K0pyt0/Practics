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
                if (inp == 0)
                {
                    if (count > max) max = count; 
                    count = 0;
                }
                if (inp == 1) count++;
                inp = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(max);
        }
    }
}
