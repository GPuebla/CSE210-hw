using System;

public abstract class  Shape
{
    private String _color;

    public String GetColor()
    {
        return _color;
    }

    public void SetColor( String color)
    {
        _color = color;
    }

    public abstract double GetArea();

}