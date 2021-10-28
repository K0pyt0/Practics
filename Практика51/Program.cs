using System;

namespace Практика51
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int ans = a % b;
                Console.WriteLine(ans);
                Console.WriteLine();

            }
        }
    }
}
