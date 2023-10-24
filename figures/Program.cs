using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figures.figures;

namespace figures
{

    class main
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double h = 0;
            while (true)
            {
                Console.WriteLine("Выберите фигуру:\n1. Квадрат \n2. Прямоугольник \n3. Треугольник \n4. Круг \n5. Пирамида");

                ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);

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
                        pyramid_choice(a, b, c, h);
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
        
        static void pyramid_choice(double a, double b, double c, double h) //надо подумать над тем включить ли методы пирамид сразу в свитч или оставить в методах
        {
            Console.WriteLine("Выберите пирамиду:\n1. Квадратная пирамида \n2. Прямоугольная пирамида \n3. Конус \n4. Треугольная пирамида");

            ConsoleKeyInfo keyInfo2 = Console.ReadKey(true);
            
            switch (keyInfo2.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    main_square_pyramid(a, h);

                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    main_rectangle_pyramid(a, b, h);

                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    main_cone(a, h);

                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    main_triangle_pyramid(a, b, c, h);
                    break;
            }
        } 

        static void main_square_pyramid(double a, double h)
        {
            Console.WriteLine("Введите сторону квадрата основания пирамиды");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамиды");
            h = double.Parse(Console.ReadLine());
            square_pyramid pyramid = new square_pyramid(a, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }

        static void main_rectangle_pyramid(double a, double b, double h)
        {
            Console.WriteLine("Введите длину прямоугольника основания пирамиды");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника основания пирамиды");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамиды");
            h = double.Parse(Console.ReadLine());
            rectangle_pyramid pyramid = new rectangle_pyramid(a, b, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();
        }

        static void main_cone (double a, double h)
        {
            Console.WriteLine("Введите радиус круга основания конуса");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту конуса");
            h = double.Parse(Console.ReadLine());
            cone pyramid = new cone(a, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();

        }

        static void main_triangle_pyramid(double a, double b, double c, double h)
        {
            Console.WriteLine("Введите A сторону основания треугольной пирамиды");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B сторону основания треугольной пирамиды");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C сторону основания треугольной пирамиды");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамиды");
            h = double.Parse(Console.ReadLine());
            triangle_pyramid pyramid = new triangle_pyramid(a, b, c, h);
            Console.Clear();
            pyramid.Out();
            Console.WriteLine();

        }
    }
}