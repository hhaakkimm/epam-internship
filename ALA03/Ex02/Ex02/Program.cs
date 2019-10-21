using System;

namespace Ex02
{
    abstract class Shape
    {

        public Shape(double a)
        {
            Side = a;
        }

        public Shape(double a, double b)
        {
            Side = a;
            Side2 = b;
        }

        public Shape(double a, double b, double c)
        {
            // Shape(a, b);
            Side  = a;
            Side2 = b;
            Side3 = c;
        }

        public double Side { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public abstract double Area { get; }
        public abstract double Perimeter { get;  }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
