namespace HorizonCalculator.Models;

public class Calculations
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
