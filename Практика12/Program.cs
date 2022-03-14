using System;

namespace Практика12
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;

        Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        Point3D(decimal num)
        {
            x = (double)Math.Floor(num);
            num -= Math.Floor(num);
            while (Math.Floor(num) != num) num *= 10;
            y = (double)num;
            z = 0;
        }

        static public Point3D InputPoint3D()
        {
            Point3D point;
            Console.WriteLine(@"Как вы ходите создать точку?
1 - не вводя ничего
2 – вводя все координаты
3 – вводя х и у через вещественное число");
            switch (Console.ReadLine())
            {
                case "1":
                    point = new Point3D();
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Введите координаты точки. Удостоверьтесь, что хотя бы одна из них кратна 5");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());
                        if (x % 5 == 0 || y % 5 == 0 || z % 5 == 0) point = new Point3D(x, y, z);
                        else throw new Exception("Вы неудачник. Вы неспособны понять простейшее условие. Созданная точка приговаривается к конструктору по умолчанию.");
                    }
                    catch(Exception error)
                    {
                        point = new Point3D();
                        Console.WriteLine(error.Message);
                    }
                    break;
                case "3":
                    Console.WriteLine("Введите вещественное число");
                    decimal xy = decimal.Parse(Console.ReadLine());
                    point = new Point3D(xy);
                    break;
                default:
                    point = new Point3D();
                    break;
            }
            return point;
        }

        public void Move(int axis, double distance)
        {
            switch (axis)
            {
                case 1: x += distance; break;
                case 2: y += distance; break;
                case 3: z += distance; break;
                default: throw new Exception("Мимо");
            }
        }

        public void Print()
        {
            Console.WriteLine($"x: {x:F0}; y: {y:F0}; z: {z:F0}");
        }

        public double DistanceToZero
        {
            get { return Math.Sqrt(x * x + y * y + z * z); }
        }

        public void SumPoints(Point3D point)
        {
            x += point.x;
            y += point.x;
            z += point.x;
        }

        public Point3D SumPoints(Point3D point1, Point3D point2)
        {
            Point3D ansPoint = new Point3D();
            ansPoint.x = point1.x + point2.x;
            ansPoint.y = point1.y + point2.y;
            ansPoint.z = point1.z+ point2.z;
            return ansPoint;
        }

        public void SumPoints(double plus)
        {
            x += plus;
            y += plus;
            z += plus;
        }

        public double X
        {
            get { return x; }
            set
            {
                try
                {
                    if (value > 0) x = value;
                    else throw new Exception("переменная должна быть больше нуля");
                }
                catch (Exception error)
                {
                    Console.WriteLine("Возникла ошибка: " + error.Message);
                }
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                try
                {
                    if (value > 0 && value < 100) y = value;
                    else throw new Exception("переменная должна быть больше нуля и меньше ста, она была приравнена к 100");
                }
                catch (Exception error)
                {
                    y = 100;
                    Console.WriteLine("Возникла ошибка: " + error.Message);
                }
            }
        }

        public double Z
        {
            get { return z; }
            set
            {
                try
                {
                    if (value < x + y) z = value;
                    else throw new Exception($"{value} чуть больше, чем {x + y}");
                }
                catch (Exception error)
                {
                    Console.WriteLine("Возникла ошибка: " + error.Message);
                }
            }
        }

        public bool IsIn
        {
            get
            {
                return x < 10 && y > 2 && y < x;
            }
        }


    }

    class MainClass
    {
        public static void Main(string[] args)
        { 
            Point3D point = Point3D.InputPoint3D();

            Console.WriteLine(@"Какой метод/свойство вы хотите испытать?
1 - сдвинуть точку по введённой оси
2 - узнать радиус-вектор
3 - сложить точку с другой
4 - сложить точку с числом
5 - узнать, входит ли точка в область");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("X - 1\nY - 2\nZ - 3");
                    int axis = int.Parse(Console.ReadLine());
                    Console.Write("Введите расстояние");
                    int distance = int.Parse(Console.ReadLine());
                    point.Move(axis, distance);
                    point.Print();
                    break;
                case "2":
                    Console.WriteLine($"Расстояние до нуля: {point.DistanceToZero}");
                    break;
                case "3":
                    Point3D point2 = Point3D.InputPoint3D();
                    point.SumPoints(point2);
                    point.Print();
                    break;
                case "4":
                    Console.WriteLine("Введите число");
                    double var = double.Parse(Console.ReadLine());
                    point.SumPoints(var);
                    point.Print();
                    break;
                case "5":
                    Console.WriteLine(point.IsIn);
                    break;
                default:
                    throw new Exception("Возникла ошибка: введённое вами число не является ни одним из предложенных");
            }
            point.Y = -1;
            Console.ReadKey();
        }
    }
}
