using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCalisma_2
{
    class OgrenciManager
    {
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            Console.WriteLine("Yeni Eklenen Öğrenci:" + ogrenci.OgrenciAdi);
        }
        public void OgreciListesi(Ogrenci[] ogrenciler)
        {
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                Console.WriteLine("******************");
                Console.WriteLine("Ad Soyad:"+ ogrenci.OgrenciAdi);
                Console.WriteLine("Numarasi:"+ ogrenci.OgrenciNum);
                Console.WriteLine("Seviyesi:"+ ogrenci.Seviyesi);
                Console.WriteLine("Yaşı:"+ ogrenci.Yasi);
                Console.WriteLine("Okulu:" + ogrenci.Okulu);
                Console.WriteLine("-----------------");
                
            }

            Console.ReadLine();
        } 
    }
}
