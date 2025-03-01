public class Mgz_Siparis
{
    public int SiparisId {get; set;}
    public int MusteriId {get; set;}
    public DateTime SiparisTarihi {get; set;}
    public decimal ToplamTutar {get; set;}
    public string? SiparisDurumu {get; set;}
    public List<SiparisDetay> SiparisDetaylari {get; set;}
}