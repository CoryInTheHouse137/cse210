using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1; 
    }
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
        
    }
    public Fraction(int topper, int bottomer)
    {
        _top = topper;
        _bottom = bottomer;

    }

    public string FractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double DecimalDouble()
    {
        return (double)_top / (double)_bottom;
    }
}