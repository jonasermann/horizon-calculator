using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HorizonCalculator.Models;

namespace HorizonCalculator.Controllers;

public class HomeController : Controller
{
    public ActionResult<Calculations> Index()
    {
        return View();
    }
}
