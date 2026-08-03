using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 4);
        // Console.WriteLine(s.GetColor());
        // Console.WriteLine(s.GetArea());

        Rectangle r = new Rectangle("yellow", 5, 6);
        // Console.WriteLine(r.GetColor());
        // Console.WriteLine(r.GetArea());

        Circle c = new Circle("red", 7);
        // Console.WriteLine(c.GetColor());
        // Console.WriteLine(c.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape b in shapes)
        {
            string color = b.GetColor();
            double area = b.GetArea();

            Console.WriteLine($"The color {color} shape has the area of {area}");
        }

    }
}