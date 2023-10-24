using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class cone : Circle
    {
        private double h;

        public cone(double rad, double h) : base(rad)
        {
            this.h = h;
        }

        private double slant_height()
        {
            return Math.Sqrt(Math.Pow(rad, 2) + Math.Pow(h, 2));
        }

        private double total_surface_area()
        {
            double l = slant_height();
            double x = Math.PI * rad * l;

            return base.area() + x;
        }

        private double volume()
        {
            return (1.0 / 3) * area() * h;
        }

        public new void Out()
        {
            Console.WriteLine($"Полная площадь поверхности конуса: {total_surface_area():f3}");
            Console.WriteLine($"Периметр основания конуса {perimeter():f3}");
            Console.WriteLine($"Объем конуса: {volume():f3}");
        }
    }
}

