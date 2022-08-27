using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    public double Radius { get; set; }

    public double ObserverObjectGeographicalDistance { get; set; }



    public double ObserverHeight { get; set; }

    public double ObserverVerticalDrop => GetVerticalDrop(Radius, ObserverHeight); 

    public double ObserverHorizontalDrop => GetHorizontalDrop(Radius, ObserverHeight, ObserverVerticalDrop);

    public double ObserverAngle => GetAngle(Radius, ObserverHorizontalDrop);

    public double ObserverHorizonGeographicalDistance => GetHorizonGeographicalDistance(Radius, ObserverAngle);



    public double ObjectHeight { get; set; }

    public double ObjectVerticalDrop => GetVerticalDrop(Radius, ObjectHeight);

    public double ObjectHorizontalDrop => GetHorizontalDrop(Radius, ObjectHeight, ObjectVerticalDrop);

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

    public static double GetAngle(double radius, double horizontalDrop)
    {
        return Math.Asin(horizontalDrop / radius);
    }

    public static double GetHorizonGeographicalDistance(double radius, double angle)
    {
        return radius * angle;
    }



    public static double GetAngleReversed(double radius, double horizonGeographicalDistance)
    {
        return horizonGeographicalDistance / radius;
    }

    public static double GetHorizontalDropReversed(double radius, double angle)
    {
        return Math.Sin(angle) * radius;
    }

    public static double GetVerticalDropReversed(double radius, double horizontalDrop)
    {
        return radius - Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(horizontalDrop, 2));
    }

    public static double GetHeightReversed(double radius, double verticalDrop)
    {
        return (radius * verticalDrop) / (radius - verticalDrop);
    }

    public double ReducedHeight => GetHeightReversed(
        Radius, GetVerticalDropReversed(
            Radius, GetHorizontalDropReversed(
                Radius, GetAngleReversed(
                    Radius, ObserverObjectGeographicalDistance - ObserverHorizonGeographicalDistance))));
}
