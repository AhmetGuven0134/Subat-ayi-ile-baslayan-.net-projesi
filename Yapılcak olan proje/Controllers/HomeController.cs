using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Yapılcak_olan_proje.Models;

namespace Yapılcak_olan_proje.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

List<Mgz_Urun>Mgz_Urunler=new List<Mgz_Urun>
    { 
      new Mgz_Urun{Id=1,UrunAdi="Apple",Fiyat=100,Stok=10},
      new Mgz_Urun{Id=2,UrunAdi="Samsung",Fiyat=99,Stok=10},
      new Mgz_Urun{Id=3,UrunAdi="Toshiba",Fiyat=10,Stok=10},
      new Mgz_Urun{Id=4,UrunAdi="Dell",Fiyat=120,Stok=10},
      new Mgz_Urun{Id=5,UrunAdi="Lenovo",Fiyat=500,Stok=10},
      new Mgz_Urun{Id=6,UrunAdi="IBM",Fiyat=600,Stok=10},
      new Mgz_Urun{Id=7,UrunAdi="Cisco",Fiyat=800,Stok=10},
    };


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult urunler()
    {
        return View();
    }
    public IActionResult kullaniciGirisi()
    {
        return View();
    }
    public IActionResult kullaniciKayit()
    {
        return View();
    }
    public IActionResult kullaniciGuncelleme()
    {
        return View();
    }
    public IActionResult kullaniciListele()
    {
        return View();
    }
    public IActionResult urunEkle()
    {
        return View();
    }
    public IActionResult ufbelirle()
    {
        return View();
    }
    [HttpPost]
    public IActionResult ufbelirle(UrunFiyat ubelirle)
    {
        double satisfiyati;
        if(ModelState.IsValid)
        {
            satisfiyati = ubelirle.fiyat + (ubelirle.fiyat*ubelirle.kdv/100) + (ubelirle.fiyat*ubelirle.kar/100);
            ViewBag.SatisFiyati = ubelirle.UrunAdi +":"+ satisfiyati.ToString("F2");
            return View(ubelirle);
        }
        else{
            return View(ubelirle);
        }
    }
    public IActionResult urunSil()
    {
        return View();
    }
    public IActionResult urunListele()
    {
        return View(Mgz_Urunler);
    }
    public IActionResult urunGuncelle()
    {
        return View();
    }
    public IActionResult katagoriEkle()
    {
        return View();
    }
    public IActionResult katagoriSil()
    {
        return View();
    }
    public IActionResult katagoriGuncelle()
    {
        return View();
    }
    public IActionResult iletisim()
    {
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
