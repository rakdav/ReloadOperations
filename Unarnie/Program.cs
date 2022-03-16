namespace Unarnie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point { X = 3, Y = 4 };
            Console.WriteLine(point.ToString());
            point++;
            Console.WriteLine(point.ToString());
            ++point;
            Console.WriteLine(point.ToString());
            point--;
            Console.WriteLine(point.ToString());
            Console.WriteLine((-point).ToString());
            Point point1 = new Point { X = 1, Y = 2 };
            Point point2 = new Point { X = 3, Y = 4 };
            Vector vector1 = new Vector(point1,point2);
            Console.WriteLine(vector1.ToString());
            Vector vector2 = new Vector { X=4,Y=6};
            Vector vector3 = vector1 + vector2;
            Console.WriteLine(vector3.ToString());
            Vector vector4= vector1 - vector2;
            Console.WriteLine(vector4.ToString());
            int n = 5;
            Vector vector5 = vector3 * n;
            Console.WriteLine(vector5.ToString());
            Console.WriteLine(point1==point2);
            Console.WriteLine(point1!=point2);
            Console.WriteLine(point1>point2);
            Console.WriteLine(point1<point2);
            if(point1)
            {
                Console.WriteLine("Точка не в начале координат");
            }
            else
            {
                Console.WriteLine("Точка в начале координат");
            }
        }
    }
}
