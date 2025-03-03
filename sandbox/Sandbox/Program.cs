using System;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

public double getArea()
{
    double area = Math.PI * (radius * radius);
    return area;
}

public void DisplayCircleArea()
{
    Console.WriteLine($"the area fo the circle is {getArea()}");
}

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello world 3/3/25");

        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();
        Circle myCircle2 = new Circle(20);
        myCircle2.DisplayCircleArea();
    }
}