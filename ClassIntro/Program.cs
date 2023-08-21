﻿internal class Program
{
    public static void Main(string[] args)
    {
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.IzlemeOrani = 68;  
        
        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlemeOrani = 64; 
        
        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlemeOrani = 80;

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
        }
    }
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlemeOrani { get; set; }

}