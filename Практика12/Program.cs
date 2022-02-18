using System;

namespace Практика12
{
    class Point3D
    {
        private int x;
        private int y;
        private int z;

        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Move(int axis, int distance)
        {
            switch (axis)
            {
                case 1: x += distance; break;
                case 2: y += distance; break;
                case 3: z += distance; break;
                default: Console.WriteLine("Мимо"); break;
            }
        }

        public void Print()
        {
            Console.WriteLine($"x: {x}; y: {y}; z: {z}");
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

        public void SumPoints(int plus)
        {
            x += plus;
            y += plus;
            z += plus;
        }

        public int X
        {
            get { return x; }
            set
            {
                if (value > 0) x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0 && value < 100) y = value;
                else y = 100;
            }
        }

        public int Z
        {
            get { return z; }
            set
            {
                if (value < x + y) z = value;
                else Console.WriteLine($"{value} чуть больше, чем {x + y}");
            }
        }

        public bool IsIn
        {
            get
            {
                if (x < 10 && y > 2 && y < x) return true;
                else return false;
            }
        }


    }

    class MainClass
    { 
        public static void Main(string[] args)
        {
            Point3D defPoint = new Point3D();
            Console.WriteLine("Введите координаты точки");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Point3D point = new Point3D(x, y, z);


            Console.WriteLine("X - 1\nY - 2\nZ - 3");
            int axis = int.Parse(Console.ReadLine());
            Console.Write("Введите расстояние");
            int distance = int.Parse(Console.ReadLine());
            defPoint.Move(axis, distance);
            defPoint.Print();
            Console.WriteLine(point.DistanceToZero);
            defPoint.SumPoints(point);
            defPoint.Print();

            Console.WriteLine();
            Console.WriteLine("Хоть поздно, а вступленье есть");
            defPoint = new Point3D();
            point = new Point3D(x, y, z);
        }
    }
}
