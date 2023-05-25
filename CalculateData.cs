// fully static class 
// not allow to create non static methods
public static class CalculateData
{
    // store data in static class lives for the entire applicate using memory space
    public static int myAge;
    public static double Add(double x, double y)
    {
        double output = x + y;
        return output;
    }
}