using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _03_02_1.Models;

namespace _03_02_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Home()
    {
        return View();
    }
    public IActionResult about()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult iletisim()
    {
        return View();
    }
    public IActionResult urunler()
    {
        return View();
    }
    public IActionResult hesapla()
    {
        return View();
    }
    public IActionResult hakkimizda()
    {
        return View();
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
