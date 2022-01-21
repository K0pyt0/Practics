using System;

namespace СтупенчатыеМассивыПрактическое
{
    class MainClass
    {
        static void MakeArray()
        {
            int[][] arr;

            Console.WriteLine("Введите количество строк");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n][];

            for (int i = 1; i <= n; i++)
            {
                arr[i - 1] = new int[i * 2];
                for(int j = 0; j < i * 2; j++)
                {
                    arr[i - 1][j] = i + j - 1;
                }
            }
            PrintArr(arr);
        }

        static void PrintArr(int[][] arr)
        {
            foreach(int[] i in arr)
            {
                foreach (int j in i) Console.Write($"{j} ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            MakeArray();
        }
    }
}
