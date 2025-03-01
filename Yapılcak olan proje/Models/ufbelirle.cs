using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.SignalR;

public class UrunFiyat
{
    public string UrunAdi { get; set; }
    public int kdv { get; set; }
    public int kar{ get; set; }
    public int fiyat { get; set; }
}