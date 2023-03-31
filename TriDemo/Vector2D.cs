using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TriDemo
{
    class Vector2D
    {
        private double x;
        private double y;

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public Vector2D Normalized()
        {
            double length = Length();
            return new Vector2D(x / length, y / length);
        }

        public double Dot(Vector2D other)
        {
            return x * other.x + y * other.y;
        }

        public Vector2D Multiply(double factor)
        {
            return new Vector2D(x * factor, y * factor);
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
            => new Vector2D(a.x + b.x, a.y + b.y);

        public static Vector2D operator -(Vector2D a, Vector2D b)
            => new Vector2D(a.x - b.x, a.y - b.y);

        public double X
        {
            get => x;
        }

        public double Y
        {
            get => y;
        }

        public PointF ToPoint()
        {
            return new PointF((float)x, (float)y);
        }
    }
}
