using System.Text.Json.Serialization;

namespace HorizonCalculator.Models;

public class Calculations
{
    [JsonPropertyName("observerHeight")]
    public int ObserverHeight { get; set; }

    [JsonPropertyName("objectHeight")]
    public int ObjectHeight { get; set; }

    [JsonPropertyName("observerObjectDistance")]
    public int ObserverObjectDistance { get; set; }
}
