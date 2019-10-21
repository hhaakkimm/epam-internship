using System;

namespace Ex02
{
    class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : base(a, b, c) { }

        public override double Area
        {
            get { return (base.Side * base.Side2) / 2; }
        }

        public override double Perimeter
        {
            get { return (base.Side + base.Side2 + base.Side3); }
        }
    }
}