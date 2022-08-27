using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HorizonCalculator.Models;

namespace HorizonCalculator.Controllers;

public class HomeController : Controller
{
    public ActionResult<Calculations> Index(double ObserverHeight, double ObjectHeight, double ObserverObjectGeographicalDistance) => View(new Calculations
    {
        Radius = 6371,
        ObserverHeight = ObserverHeight,
        ObjectHeight = ObjectHeight,
        ObserverObjectGeographicalDistance = ObserverObjectGeographicalDistance
    });
}
