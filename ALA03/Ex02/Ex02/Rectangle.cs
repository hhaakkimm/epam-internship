using System;

namespace Ex02
{
    class Rectangle : Shape
    {
        public Rectangle(double a, double b) : base(a, b) { }

        public override double Area
        {
            get { return base.Side * base.Side2; }
        }

        public override double Perimeter
        {
            get { return 2 * (base.Side + base.Side2); }
        }
    }
}