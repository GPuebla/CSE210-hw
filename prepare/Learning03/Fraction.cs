public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    public int GetTop()
    {
        return this._top;
    }

    public void SetTop( int top)
    {
        this._top = top;
    }

    public int GetBottom()
    {
        return this._bottom;
    }

    public void SetBottom( int bottom)
    {
        this._bottom = bottom;
    }

    public String GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public Double GetDecimalValue()
    {
        return _top / _bottom;
    }

}