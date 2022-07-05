using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    [JsonPropertyName("radius")]
    public double Radius { get; set; }

    [JsonPropertyName("observerHeight")]
    public double ObserverHeight { get; set; }

    [JsonPropertyName("objectHeight")]
    public double ObjectHeight { get; set; }

    [JsonPropertyName("observerObjectDistance")]
    public double ObserverObjectDistance { get; set; }

    public double ObserverVerticalDrop
    {
        get { return GetObserverVerticalDrop(Radius, ObserverHeight); }
    }

    public double ObserverHorizontalDrop
    {
        get { return GetObserverHorizontalDrop(Radius, ObserverHeight, ObserverVerticalDrop); }
    }

    public double HorizonDistance
    {
        get { return GetHorizonDistance(Radius, ObserverHeight); }
    }

    public static double GetObserverVerticalDrop(double radius, double observerHeight)
    {
        return observerHeight * radius / (observerHeight + radius);
    }

    public static double GetObserverHorizontalDrop(double radius, double observerHeight, double observerVerticalDrop)
    {
        return observerVerticalDrop * Math.Sqrt(1 + (2 * radius / observerHeight));
    }

    public static double GetHorizonDistance(double radius, double observerHeight)
    {
        return Math.Sqrt(Math.Pow(observerHeight, 2) + 2 * observerHeight * radius);
    }
}
