public class Kategori
{
    public int kategori_id { get; set; }
    public string kategori_adi { get; set; }
    public string Aciklama { get; set; }
    public List<Mgz_Urun> Urunler { get; set; }
}
