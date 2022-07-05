using Xunit;
using FluentAssertions;
using static HorizonCalculator.Models.Calculations;

namespace HorizonCalculator.Tests;

public class HorizonCalculatorTests
{
    [Fact]
    public void GetObserverVerticalDrop_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHeight = 0.002;
        var observerVerticalDrop = 0.0019999993721552746;

        //Act
        var result = GetObserverVerticalDrop(earthRadius, observerHeight);

        //Assert
        result.Should().Be(observerVerticalDrop);
    }
}