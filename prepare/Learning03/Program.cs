using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
    class Fraction
{
    private int top;
    private int bottom;

    // These are Constructors
    public Fraction() { top = 1; bottom = 1; }
    public Fraction(int top) { this.top = top; bottom = 1; }
    public Fraction(int top, int bottom) { this.top = top; this.bottom = bottom; }

    //These are Getters and Setters
    public int Top { get { return top; } set { top = value; } }
    public int Bottom { get { return bottom; } set { bottom = value; } }

    // The Methods
    public string GetFractionString() { return top + "/" + bottom; }
    public double GetDecimalValue() { return (double)top / bottom; }
}
}