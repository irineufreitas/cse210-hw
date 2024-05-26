using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        

        Square square = new Square("Black", 5);
        Console.WriteLine(square.GetArea());

        Console.WriteLine(square.GetColor());

        Rectangle rectangle = new Rectangle("white", 3, 4);
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Yellow", 6.5);
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Purple", 3));
        shapes.Add(new Rectangle ("Pink", 3, 7));
        shapes.Add(new Circle("Blue", 4));

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"{color} - {area}");
        }


    }
}