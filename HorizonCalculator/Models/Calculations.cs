using static HorizonCalculator.Models.CalculationMethods;

namespace HorizonCalculator.Models;

public class Calculations
{
    public double Radius { get; set; }

    public double ObserverHeight { get; set; }

    public double ObjectHeight { get; set; }

    public double ObserverObjectGeographicalDistance { get; set; }

    public double ObserverHeightInKm => ObserverHeight / 1000;

    public double ObjectHeightInKm => ObjectHeight / 1000;

    public double ObserverVerticalDrop => GetVerticalDrop(Radius, ObserverHeightInKm);

    public double ObserverHorizontalDrop => GetHorizontalDrop(Radius, ObserverHeightInKm, ObserverVerticalDrop);

    public double ObserverAngle => GetAngle(Radius, ObserverHorizontalDrop);

    public double ObserverHorizonGeographicalDistance => Math.Round(GetHorizonGeographicalDistance(Radius, ObserverAngle), 2);

    public double ReducedObjectHeight => GetHeightFromVerticalDrop(
        Radius, GetVerticalDropFromHorizontalDrop(
            Radius, GetHorizontalDropFromAngle(
                Radius, GetAngleFromHorizonGeographicalDistance(
                    Radius, ObserverObjectGeographicalDistance - ObserverHorizonGeographicalDistance))));

    public double VisibleObjectHeight => Math.Round((ObjectHeightInKm - ReducedObjectHeight) * 1000, 2);

}
