using System;

namespace Практика72
{
    class MainClass
    {
        static void SetBigg(ref int a)
        {
            for (int i = a / 2; i > 0; i--)
            {
                if ((a % i) == 0)
                {
                    a = i;
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            SetBigg(ref a);
            Console.WriteLine(a);
        }
    }
}
