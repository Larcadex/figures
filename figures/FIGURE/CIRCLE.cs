using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Circle
    {
        protected double rad;

        public Circle(double rad)
        {
            this.rad = rad;
        }

        protected double perimeter()
        { return (2 * 3.14 * rad); }

        protected double area()
        { return (3.14 * (rad * rad)); }

        public void Out()
        {
            Console.WriteLine($"Круг с радиусом {rad}");
            Console.WriteLine($"Площадь круга: {area()}");
            Console.WriteLine($"Периметр круга: {perimeter()}");
        }
    }
}