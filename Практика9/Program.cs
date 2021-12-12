using System;

namespace Практика9
{
    class Program
    {
        static string Every3Dot(string s)
        {
            for (int i = s.Length - 3; i >= 0; i = i - 3)
            {
                s = s.Insert(i, ".");
            }
            return s;
        }
        
        static string Focuses(string s, string subs)
        {
            int len = subs.Length;
            while (s.IndexOf(subs) != -1)
            {
                s = s.Remove(s.IndexOf(subs), len);
            }
            return s;
        }

        static string DeleteMiddle(string s)
        {
            if (s.Length % 2 == 1) s = s.Remove(s.Length / 2, 1);
            else s = s.Remove(s.Length / 2 - 1, 2);
            return s;
        }
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string subs = Console.ReadLine();

            Console.WriteLine(Every3Dot(s));
            Console.WriteLine(Focuses(s, subs));
            Console.WriteLine(DeleteMiddle(s));
            Console.ReadKey();
        }
    }
}
