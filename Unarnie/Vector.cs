using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unarnie
{
    internal class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public Vector() { }
        public Vector(Point start, Point end) 
        {
            X = end.X-start.X;
            Y= end.Y-start.Y;
        }
        public static Vector operator +(Vector v1,Vector v2)
        {
            return new Vector { X=v1.X+v2.X, 
                                Y=v1.Y+v2.Y};
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, 
                                Y = v1.Y - v2.Y };
        }
        public static Vector operator *(Vector v,int n)
        {
            return new Vector { X = v.X * n, Y = v.Y * n };
        }

        public override string? ToString()
        {
            return $"Vector: X={X}, Y={Y}";
        }
    }
}
