using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.FractionString());
        Console.WriteLine(fraction.DecimalDouble());


        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.FractionString());
        Console.WriteLine(fraction1.DecimalDouble());

        Fraction fraction2 = new Fraction(5,1);
        Console.WriteLine(fraction2.FractionString());
        Console.WriteLine(fraction2.DecimalDouble());
        
        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.FractionString());
        Console.WriteLine(fraction3.DecimalDouble());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.FractionString());
        Console.WriteLine(fraction4.DecimalDouble());
    }
}