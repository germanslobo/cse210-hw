using System;
using System.Collections.Generic;

namespace Shapes;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a list that holds Shape objects
        List<Shape> shapes = new List<Shape>();

        // 2. Add different instances to the list
        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 4.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        // 3. Iterate through the list and display color and area polymorphic behavior
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}