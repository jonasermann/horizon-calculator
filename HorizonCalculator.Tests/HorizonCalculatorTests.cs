using Xunit;
using FluentAssertions;
using static HorizonCalculator.Models.CalculationMethods;

namespace HorizonCalculator.Tests;

public class HorizonCalculatorTests
{
    [Fact]
    public void GetVerticalDrop_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHeight = 0.002;
        var observerVerticalDrop = 0.0019999993721552746;

        //Act
        var result = GetVerticalDrop(earthRadius, observerHeight);

        //Assert
        result.Should().Be(observerVerticalDrop);
    }

    [Fact]
    public void GetHorizontalDrop_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHeight = 0.002;
        var observerVerticalDrop = 0.0019999993721552746;
        var observerHorizontalDrop = 5.048166795977033;

        //Act
        var result = GetHorizontalDrop(earthRadius, observerHeight, observerVerticalDrop);

        //Assert
        result.Should().Be(observerHorizontalDrop);
    }

    [Fact]
    public void GetAngle_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHorizontalDrop = 5.048166795977033;
        var observerObjectAngle = 0.0007923665553635612;

        //Act
        var result = GetAngle(earthRadius, observerHorizontalDrop);

        //Assert
        result.Should().Be(observerObjectAngle);
    }


    [Fact]
    public void GetHorizonGeographicalDistance_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerObjectAngle = 0.0007923665553635612;
        var horizonGeographicalDistance = 5.048167324221248;

        //Act
        var result = GetHorizonGeographicalDistance(earthRadius, observerObjectAngle);

        //Assert
        result.Should().Be(horizonGeographicalDistance);
    }
}
