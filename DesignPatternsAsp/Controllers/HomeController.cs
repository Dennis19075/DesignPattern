using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignPatternsAsp.Models;
using Tools;
using Microsoft.Extensions.Options;
using DesignPatternsAsp.Configuration;

namespace DesignPatternsAsp.Controllers;

public class HomeController : Controller
{
    private readonly IOptions<MyConfig> _config;

    public HomeController(IOptions<MyConfig> config)
    {
        _config = config;
    }

    public IActionResult Index()
    {
        Log.GetInstance(_config.Value.pathLog).Save("Entro a index");
        return View();
    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_config.Value.pathLog).Save("Entro a privacy");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

