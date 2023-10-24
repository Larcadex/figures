using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class rectangle_pyramid : Rectangle
    {
        private double h;


        public rectangle_pyramid(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }


        private double total_surface_area()
        {
            double x = a * Math.Sqrt(Math.Pow(b / 2, 2) + Math.Pow(h, 2)) + b * Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));

            return area() + x; ;
        }


        private double volume()
        {
            return (1.0 / 3) * area() * h;
        }
        
        public new void Out()
        {
            Console.WriteLine($"Полная площадь поверхности пирамиды: {total_surface_area():f3}");
            Console.WriteLine($"Периметр основания пирамиды: {perimeter():f3}");
            Console.WriteLine($"Объем пирамиды: {volume():f3}");
        }


    }
}

