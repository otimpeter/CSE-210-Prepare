    using System;
    class Program
    {
         static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
    }
    {
            Square square = new Square("Red", 5);
            Console.WriteLine("Color: " + square.GetColor());
            Console.WriteLine("Area: " + square.GetArea());

            Rectangle rectangle = new Rectangle("Blue", 5, 10);
            Console.WriteLine("Color: " + rectangle.GetColor());
            Console.WriteLine("Area: " + rectangle.GetArea());
            using System;

            Circle circle = new Circle("Green", 5);
            Console.WriteLine("Color: " + circle.GetColor());
            Console.WriteLine("Area: " + circle.GetArea());

            List<Shape> shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Color: " + shape.GetColor());
                Console.WriteLine("Area: " + shape.GetArea());
            }
        }
    } 
    

    

    