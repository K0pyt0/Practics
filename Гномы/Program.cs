using System;

namespace Гномы
{
    class MainClass
    {
        static int InputGN()
        {
            Console.WriteLine("Введите количество гномов (16 или 32):");
            int GN = int.Parse(Console.ReadLine());
            if (GN == 16 || GN == 32) return GN;
            else return WrongInputGN();
        }

        static int WrongInputGN()
        {
            Console.WriteLine("Ошибка: введённое число должно быть равно 16 или 32. Повторите ввод:");
            int GN = int.Parse(Console.ReadLine());
            if (GN == 16 || GN == 32) return GN;
            else return WrongInputGN();
        }

        static uint InputGP()
        {
            Console.WriteLine("Введите число, двоичный код которого представляет гномов:");
            uint GP = uint.Parse(Console.ReadLine());
            return GP;
        }

        static void Output(uint GP, int GN)
        {
            Console.WriteLine("Гномы:");
            int i = 32 - GN;
            for (; i < 32; i++)
            {
                if (((GP << i) & 0x80000000) == 0x80000000) Console.Write("1");
                else Console.Write("0");
            }
            Console.WriteLine();
        }

        static bool AreForwardEven(uint GP, int GN, int pos)
        {
            GP >>= pos;
            int count = 0;
            for (int i = 1; i <= (GN - pos); i++)
            {
                if (((GP >> i) & 1) == 1) count++;
            }
            if (count % 2 == 0)
            {
                //Console.WriteLine("Forward are even");
                return true;
            }
            else
            {
                //Console.WriteLine("Forward are uneven");
                return false;
            }
        }
        
        static void Say(bool ans, uint GP, int pos, ref int score)
        {
            bool rans = ((GP >> pos) & 1) != 1;
            if (ans) Console.WriteLine($"{pos + 1}-й гном сказал: \"Я в зелёной шапке.\"");
            else Console.WriteLine($"{pos + 1}-й гном сказал: \"Я в красной шапке.\"");
            if (ans == rans)
            {
                score++;
                Console.WriteLine($"{pos + 1}-й гном угадал и получил монету. Общий счёт гномов: {score}");
            }
            else Console.WriteLine($"{pos + 1}-й гном ошибся и не получил ни одной монеты. Общий счёт гномов: {score}");
        }

        public static void Main(string[] args)
        {
            int GN = InputGN();
            uint GP = InputGP();
            Output(GP, GN);
            int score = 0;

            bool isNumEven = AreForwardEven(GP, GN, 0);
            Say(isNumEven, GP, 0, ref score);
            for (int i = 1; i < GN; i++)
            {
                //Console.WriteLine(isNumEven);
                if (isNumEven == AreForwardEven(GP, GN, i)) Say(true, GP, i, ref score);
                else
                {
                    Say(false, GP, i, ref score);
                    if (isNumEven) isNumEven = false;
                    else isNumEven = true;
                }
            }
            Console.ReadKey();
        }
    }
}
