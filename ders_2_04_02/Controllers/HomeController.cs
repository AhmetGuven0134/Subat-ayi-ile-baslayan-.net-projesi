using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ders_2_04_02.Models;

namespace ders_2_04_02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult Home()
    {
        return View();
    }
    public IActionResult about()
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
