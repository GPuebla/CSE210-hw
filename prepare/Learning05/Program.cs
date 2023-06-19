using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        square1.SetColor("red");
        square1.SetSide(23.5);

        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetColor("blue");
        rectangle1.SetLength(5.2);
        rectangle1.SetWidth(10);

        Circle circle1 = new Circle();
        circle1.SetColor("green");
        circle1.SetRadio(6.9);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (var item in shapes)
        {
            DisplayInformationShape(item);
        }
    }

    public static void DisplayInformationShape( Shape s)
    {
       Console.WriteLine($"{s.GetColor()} -> Area: {s.GetArea()}cm.");
    }
}