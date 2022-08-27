using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    public double Radius { get; set; }

    public double ObserverHeight { get; set; }

    public double ObjectHeight { get; set; }

    public double ObserverObjectGeographicalDistance { get; set; }




    public double ObserverVerticalDrop => GetVerticalDrop(Radius, ObserverHeight); 

    public double ObserverHorizontalDrop => GetHorizontalDrop(Radius, ObserverHeight, ObserverVerticalDrop);

    public double ObserverAngle => GetAngle(Radius, ObserverHorizontalDrop);

    public double ObserverHorizonGeographicalDistance => GetHorizonGeographicalDistance(Radius, ObserverAngle);

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



    public double ReducedObjectHeight => GetHeightFromVerticalDrop(
        Radius, GetVerticalDropFromHorizontalDrop(
            Radius, GetHorizontalDropFromAngle(
                Radius, GetAngleFromHorizonGeographicalDistance(
                    Radius, ObserverObjectGeographicalDistance - ObserverHorizonGeographicalDistance))));

    public double VisibleObjectHeight => ObjectHeight - ReducedObjectHeight;

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
