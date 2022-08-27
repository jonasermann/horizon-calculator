using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    public double Radius { get; set; }

    public double ObserverHeight { get; set; }

    

    public double ObserverObjectGeographicalDistance { get; set; }

    public double ObserverVerticalDrop => GetVerticalDrop(Radius, ObserverHeight); 

    public double ObserverHorizontalDrop => GetHorizontalDrop(Radius, ObserverHeight, ObserverVerticalDrop);

    public double ObserverHorizonDistance => GetHorizonDistance(Radius, ObserverHeight);

    public double ObserverAngle => GetAngle(Radius, ObserverHorizontalDrop);

    public double ObserverHorizonGeographicalDistance => GetHorizonGeographicalDistance(Radius, ObserverAngle);



    public double ObjectHeight { get; set; }

    public double ObjectVerticalDrop => GetVerticalDrop(Radius, ObjectHeight);

    public double ObjectHorizontalDrop => GetHorizontalDrop(Radius, ObjectHeight, ObjectVerticalDrop);

    public double ObjectHorizonDistance => GetHorizonDistance(Radius, ObjectHeight);

    public double ObjectAngle => GetAngle(Radius, ObjectHorizontalDrop);

    public double ObjectHorizonGeographicalDistance => GetHorizonGeographicalDistance(Radius, ObjectAngle);



    public static double GetVerticalDrop(double radius, double height)
    {
        return height * radius / (height + radius);
    }

    public static double GetHorizontalDrop(double radius, double height, double verticalDrop)
    {
        return verticalDrop * Math.Sqrt(1 + (2 * radius / height));
    }

    public static double GetHorizonDistance(double radius, double height)
    {
        return Math.Sqrt(Math.Pow(height, 2) + 2 * height * radius);
    }

    public static double GetAngle(double radius, double horizontalDrop)
    {
        return Math.Asin(horizontalDrop / radius);
    }

    public static double GetHorizonGeographicalDistance(double radius, double angle)
    {
        return radius * angle;
    }
}
