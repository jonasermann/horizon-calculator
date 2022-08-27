using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HorizonCalculator.Models;

namespace HorizonCalculator.Controllers;

public class CalculationsController : Controller
{
    public ActionResult<Calculations> Index(double ObserverHeight, double ObjectHeight, double ObserverObjectGeographicalDistance) => View(new Calculations
    {
        Radius = 6371,
        ObserverHeight = ObserverHeight / 1000,
        ObjectHeight = ObjectHeight / 1000,
        ObserverObjectGeographicalDistance = ObserverObjectGeographicalDistance
    });
}
