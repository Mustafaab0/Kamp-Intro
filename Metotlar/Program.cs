using Metotlar;

internal class Program
{
    public static void Main(string[] args)
    {

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 10;
        urun2.Aciklama = "Diyarbakır Karpuzu";

        Urun[] urunler = new Urun[] {urun1, urun2 };

        foreach (Urun urun in urunler)
        {
            Console.WriteLine("Ürün Adı : " + urun.Adi);
            Console.WriteLine("Ürün Fiyati : " + urun.Fiyati);
            Console.WriteLine("Ürün Açıklaması : " + urun.Aciklama);
            Console.WriteLine("----------------------------------");
        }

        Console.WriteLine("------------ Metodlar ------------");

        //instance - class örneği
        SepetManager sepetManager = new SepetManager();

        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
        sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
        sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
    }
}