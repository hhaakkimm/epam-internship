using System;

namespace Ex02
{
    class Circle : Shape
    {
        public Circle(double a) : base(a) { }
        public override double Area
        {
            get { return Math.PI * Math.Pow(base.Side, 2); }
        }
        public override double Perimeter
        {
            get { return (2 * Math.PI * base.Side); }
        }
    }
}