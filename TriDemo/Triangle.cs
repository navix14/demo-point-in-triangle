using System;
using System.Collections.Generic;
using System.Text;

namespace TriDemo
{
    class Triangle
    {
        private Vector2D a, b, c;

        public Triangle(Vector2D a, Vector2D b, Vector2D c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Vector2D A
        {
            get => a;
        }
        public Vector2D B
        {
            get => b;
        }
        public Vector2D C
        {
            get => c;
        }

        public bool Contains(Vector2D point)
        {
            // Get vector to `point` relative to A.
            Vector2D p = point - a;

            // Get intersection point between line formed by `p`
            // and line formed by triangle side BC.
            // Note: This is simply the formula we derived above.
            double numerator = (b.Y - a.Y) * (b.X - c.X)
                             - (b.X - a.X) * (b.Y - c.Y);

            double denominator = (point.Y - a.Y) * (b.X - c.X)
                               - (point.X - a.X) * (b.Y - c.Y);

            double t = numerator / denominator;

            Vector2D intersect = a + p.Multiply(t);

            // Check the three conditions hold.
            Vector2D AS = intersect - a;
            Vector2D BS = intersect - b;
            Vector2D CS = intersect - c;
            Vector2D BC = c - b;

            return t > 0 &&
                   p.Length() <= AS.Length() &&
                   Math.Max(BS.Length(), CS.Length()) < BC.Length();
        }
    }
}
