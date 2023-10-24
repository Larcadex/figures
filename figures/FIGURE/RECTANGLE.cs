using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Rectangle
    {
        protected double a;
        protected double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        protected double perimeter()
        { return (2 * (a + b)); }

        protected double area()
        { return (a * b); }

        public void Out()
        {
            Console.WriteLine($"Площадь прямоугольника: {area():f3}");
            Console.WriteLine($"Периметр прямоугольника:  {perimeter():f3}");
        }
    }
}