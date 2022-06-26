using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    private double _earthRadiusInKm = 6371;

    [JsonPropertyName("observerHeight")]
    public double ObserverHeight { get; set; }

    [JsonPropertyName("objectHeight")]
    public double ObjectHeight { get; set; }

    [JsonPropertyName("observerObjectDistance")]
    public double ObserverObjectDistance { get; set; }

    public double ObserverVerticalDrop
    {
        get { return (ObserverHeight * _earthRadiusInKm) / (ObserverHeight + _earthRadiusInKm); }
    }
}
