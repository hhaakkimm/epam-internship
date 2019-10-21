using System;

namespace Ex02
{
    class Square : Shape
    {
        public Square(double a) : base(a) { }

        public override double Area
        {
            get { return Math.Pow(base.Side, 2); }
        }

        public override double Perimeter
        {
            get { return 4 * base.Side; }
        }
    }
}