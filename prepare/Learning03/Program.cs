using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(1);
        Fraction fraction3 = new Fraction(5);
        Fraction fraction4 = new Fraction(3,4);
        Fraction fraction5 = new Fraction(1,3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        fraction1.SetTop(12);
        fraction1.SetBottom(5);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(String.Format("{0:0.00}", fraction1.GetDecimalValue()));

    }
}