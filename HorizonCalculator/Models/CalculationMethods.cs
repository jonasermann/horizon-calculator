namespace HorizonCalculator.Models;

public static class CalculationMethods
{
    public static double GetVerticalDrop(double radius, double height)
    {
        return height * radius / (height + radius);
    }

    public static double GetHorizontalDrop(double radius, double height, double verticalDrop)
    {
        return verticalDrop * Math.Sqrt(1 + (2 * radius / height));
    }

    public static double GetAngle(double radius, double horizontalDrop)
    {
        return Math.Asin(horizontalDrop / radius);
    }

    public static double GetHorizonGeographicalDistance(double radius, double angle)
    {
        return radius * angle;
    }

    public static double GetAngleFromHorizonGeographicalDistance(double radius, double horizonGeographicalDistance)
    {
        return horizonGeographicalDistance / radius;
    }

    public static double GetHorizontalDropFromAngle(double radius, double angle)
    {
        return Math.Sin(angle) * radius;
    }

    public static double GetVerticalDropFromHorizontalDrop(double radius, double horizontalDrop)
    {
        return radius - Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(horizontalDrop, 2));
    }

    public static double GetHeightFromVerticalDrop(double radius, double verticalDrop)
    {
        return (radius * verticalDrop) / (radius - verticalDrop);
    }
}
