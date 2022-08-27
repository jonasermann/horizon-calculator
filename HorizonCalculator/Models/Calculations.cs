using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    public double Radius { get; set; }

    public double ObserverHeight { get; set; }

    public double ObjectHeight { get; set; }

    public double ObserverObjectGeographicalDistance { get; set; }

    public double ObserverVerticalDrop
    {
        get { return GetVerticalDrop(Radius, 1000 * ObserverHeight); }
    }

    public double ObserverHorizontalDrop
    {
        get { return GetHorizontalDrop(Radius, 1000 * ObserverHeight, ObserverVerticalDrop); }
    }

    public double HorizonDistance
    {
        get { return GetHorizonDistance(Radius, 1000 * ObserverHeight); }
    }

    public double ObserverAngle
    {
        get { return GetAngle(Radius, ObserverHorizontalDrop); }
    }

    public double HorizonGeographicalDistance
    {
        get { return GetHorizonGeographicalDistance(Radius, ObserverAngle); }
    }

    public static double GetVerticalDrop(double radius, double observerHeight)
    {
        return observerHeight * radius / (observerHeight + radius);
    }

    public static double GetHorizontalDrop(double radius, double observerHeight, double observerVerticalDrop)
    {
        return observerVerticalDrop * Math.Sqrt(1 + (2 * radius / observerHeight));
    }

    public static double GetHorizonDistance(double radius, double observerHeight)
    {
        return Math.Sqrt(Math.Pow(observerHeight, 2) + 2 * observerHeight * radius);
    }

    public static double GetAngle(double radius, double observerHorizontalDrop)
    {
        return Math.Asin(observerHorizontalDrop / radius);
    }

    public static double GetHorizonGeographicalDistance(double radius, double observerObjectAngle)
    {
        return radius * observerObjectAngle;
    }
}
