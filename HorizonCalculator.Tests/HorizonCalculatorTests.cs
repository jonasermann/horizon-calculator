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
    public void GetHorizonDistance_works()
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

    [Fact]
    public void GetObserverObjectAngle_works()
    {
        //Arrange
        var earthRadius = 6371;
        var observerHorizontalDrop = 5.048166795977033;
        var observerObjectAngle = 0.0007923665553635612;

        //Act
        var result = GetObserverObjectAngle(earthRadius, observerHorizontalDrop);

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
