using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCalisma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrenciAdi = "Akın Boztoprak";
            ogrenci1.OgrenciNum = 26451;
            ogrenci1.Seviyesi = 3;
            ogrenci1.Yasi = 38;
            ogrenci1.Okulu = "kafkas üni.";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrenciAdi = "Yalçın çarkı";
            ogrenci2.OgrenciNum = 768752;
            ogrenci2.Seviyesi = 1;
            ogrenci2.Yasi = 28;
            ogrenci2.Okulu = "Kastamonu üni.";

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.OgrenciAdi = "Ümit Çapkın";
            ogrenci3.OgrenciNum = 287864;
            ogrenci3.Seviyesi = 5;
            ogrenci3.Yasi = 38;
            ogrenci3.Okulu = "Giresun üni.";

            Ogrenci ogrenci4 = new Ogrenci();
            ogrenci4.OgrenciAdi = "Nurican Çapkın";
            ogrenci4.OgrenciNum = 254855;
            ogrenci4.Seviyesi = 6;
            ogrenci4.Yasi = 16;
            ogrenci4.Okulu = "Çorum üni.";

            Ogrenci[] ogrenciler = new Ogrenci[] { ogrenci1, ogrenci2, ogrenci3, ogrenci4 };
            OgrenciManager ogrenciManager = new OgrenciManager();
            ogrenciManager.OgrenciEkle(ogrenci1);
            ogrenciManager.OgrenciEkle(ogrenci2);
            ogrenciManager.OgrenciEkle(ogrenci3);
            ogrenciManager.OgrenciEkle(ogrenci4);

            Console.WriteLine("Öğrencileri Listele:");
            ogrenciManager.OgreciListesi(ogrenciler);

            Console.ReadLine();
           






        }
    }
}
