using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete " + urun.Adi + " eklendi!");

        }

        //Ekle2 yanlış kullanım doğru kullanım Ekle

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete " + urunAdi + " eklendi!");
        }

    }
}
