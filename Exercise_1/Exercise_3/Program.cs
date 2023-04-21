class Overloading
{
    static void Main()
    {
        Calculate(2, 2);
        Calculate(3, 3, 2);
    }

    static void Calculate(double length, double width)
    {
        Console.WriteLine("Area is: " + length * width);
    }

    static void Calculate(double length, double width, double height)
    {
        Console.WriteLine("Capacity is: " + length * width * height);
    }
}