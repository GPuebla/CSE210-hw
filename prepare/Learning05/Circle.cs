using System;

public class Circle : Shape
{
    private double _radio;

    public double GetRadio()
    {
        return _radio;
    }

    public void SetRadio(double radio)
    {
        _radio = radio;
    }

    public override double GetArea()
    {   
        double result1 = Math.Pow(_radio,2);
        return Math.PI * result1;
    }
}