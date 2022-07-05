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

    [Fact]
    public void GetObserverHorizontalDrop_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHeight = 0.002;
        var observerVerticalDrop = 0.0019999993721552746;
        var observerHorizontalDrop = 5.048166795977033;

        //Act
        var result = GetObserverHorizontalDrop(earthRadius, observerHeight, observerVerticalDrop);

        //Assert
        result.Should().Be(observerHorizontalDrop);
    }

    [Fact]
    public void GetHorizonDIstance_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHeight = 0.002;
        var horizonDistance = 5.048168380709978;

        //Act
        var result = GetHorizonDistance(earthRadius, observerHeight);

        //Assert
        result.Should().Be(horizonDistance);
    }
}
