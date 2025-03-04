//c#

class Cyilnder
{
    private double height;

    private Circle circle;

public Cyilnder(double h, Circle circle)
{
    height = h;
    this.circle = circle;
}

public double GetVolume()
{
    double volume = height * circle.GetArea();
    return volume;
}
}