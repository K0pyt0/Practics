using System;

namespace Гномы
{
    class MainClass
    {
        static uint InputGN()
        {
            Console.WriteLine("Введите количество гномов (16 или 32):");
            uint GN = uint.Parse(Console.ReadLine());
            if (GN == 16 || GN == 32) return GN;
            else return WrongInputGN();
        }

        static uint WrongInputGN()
        {
            Console.WriteLine("Ошибка: введённое число должно быть равно 16 или 32. Повторите ввод:");
            uint GN = uint.Parse(Console.ReadLine());
            if (GN == 16 || GN == 32) return GN;
            else return WrongInputGN();
        }

        static ushort InputGPS()
        {
            Console.WriteLine("Введите число, двоичный код которого представляет гномов:");
            ushort GP = ushort.Parse(Console.ReadLine());
            return GP;
        }

        static uint InputGPI()
        {
            Console.WriteLine("Введите число, двоичный код которого представляет гномов:");
            uint GP = uint.Parse(Console.ReadLine());
            return GP;
        }

        public static void Main(string[] args)
        {
            uint GN = InputGN();
            ushort GPS = InputGPS();
            uint GPI = InputGPI();

            Console.WriteLine(GN);
            Console.WriteLine($"{GPS}, {GPI}");
        }
    }
}
