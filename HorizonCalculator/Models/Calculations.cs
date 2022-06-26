using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    private int _earthRadiusInKm = 6371;

    [JsonPropertyName("observerHeight")]
    public int ObserverHeight { get; set; }

    [JsonPropertyName("objectHeight")]
    public int ObjectHeight { get; set; }

    [JsonPropertyName("observerObjectDistance")]
    public int ObserverObjectDistance { get; set; }

    public int ObserverVerticalDrop
    {
        get{ return (ObserverHeight * _earthRadiusInKm) / (ObserverHeight + _earthRadiusInKm); }
    }
}
