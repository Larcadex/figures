using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Triangle
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string get_type()
        {
            if (!valid())
            {
                return "Треугольник не существует";
            }
            else if (equilateral())
            {
                return "Равносторонний треугольник";
            }
            else if (isosceles())
            {
                return "Равнобедренный треугольник";
            }
            else if (scalene())
            {
                return "Разносторонний треугольник";
            }
            else
            {
                return "Неизвестный тип треугольника";
            }
        }

        private bool valid()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private bool isosceles()
        {
            return a == b || b == c || a == c;
        }

        private bool equilateral()
        {
            return a == b && b == c;
        }

        private bool scalene()
        {
            return a != b && b != c && a != c;
        }

        public double perimeter()
        {
            return (a + b + c);
        }

        public double area()
        {
            double s = perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void Out()
        {
            Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} является {get_type()}.");
            Console.WriteLine($"Площадь треугольника: {area()}");
            Console.WriteLine($"Периметр треугольника: {perimeter()}");
        }
    }
}