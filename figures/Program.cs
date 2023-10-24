using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{

    class main
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру:\n1. Квадрат \n2. Прямоугольник \n3. Треугольник \n4. Круг \n5. Квадратная пирамида \n6. Прямоугольная пирамида \n7. Конус \n8. Треугольная пирамида");

                ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);

                double a = 0;
                double b = 0;
                double c = 0;

                switch (keyInfo1.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        main_square(a);

                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        main_rectangle(a, b);

                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        main_triangle(a, b, c);

                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        main_circle(a);

                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        main_square_pyramid(a, b);

                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        main_rectangle_pyramid(a, b, c);

                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        main_cone(a, b, c);

                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        main_triangle_pyramid(a, b, c);

                        break;

                }

            }
        }

        static void main_square(double a)
        {
            Console.WriteLine("Введите сторону квадрата");
            a = double.Parse(Console.ReadLine());
            Square square = new Square(a);
            Console.Clear();
            square.Out();
            Console.WriteLine();
        }

        static void main_rectangle(double a, double b)
        {
            Console.WriteLine("Введите ширину прямоугольника");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину прямоугольника");
            b = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a, b);
            Console.Clear();
            rectangle.Out();
            Console.WriteLine();

        }

        static void main_triangle(double a, double b, double c)
        {
            Console.WriteLine("Введите A сторону треугольника");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B сторону треугольника");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C сторону треугольника");
            c = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a, b, c);
            Console.Clear();
            triangle.Out();
            Console.WriteLine();
        }

        static void main_circle(double a)
        {
            Console.WriteLine("Введите радиус круга");
            a = double.Parse(Console.ReadLine());
            Circle circle = new Circle(a);
            Console.Clear();
            circle.Out();
            Console.WriteLine();
        }

        static void main_square_pyramid(double a, double b)
        {
            Console.WriteLine("Введите сторону квадрата основания пирамиды");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамиды");
            b = double.Parse(Console.ReadLine());
            square_pyramid pyramid = new square_pyramid(a, b);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
       
        }

        static void main_rectangle_pyramid(double a, double b, double c)
        {
            Console.WriteLine("Введите длину прямоугольника основания пирамиды");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника основания пирамиды");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамиды");
            c = double.Parse(Console.ReadLine());
            rectangle_pyramid pyramid = new rectangle_pyramid(a, b, c);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }

        static void main_cone (double a, double b, double c)
        {
            Console.WriteLine("NotRealize");

        }

        static void main_triangle_pyramid(double a, double b, double c)
        {
            Console.WriteLine("NotRealize");

        }
    }
}