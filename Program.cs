using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "ezgi";
            musteri1.Soyadi = "doğan";
            musteri1.Id = "213456";
            musteri1.Cinsiyet = "kadın";
            musteri1.TcKimlik = "12345678998";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "ali";
            musteri2.Soyadi = "doğan";
            musteri2.Id = "233486";
            musteri2.Cinsiyet = "erkek";
            musteri2.TcKimlik = "9876543212";
            
            Musteri musteri3 = new Musteri();
            musteri3.Adi = "veli";
            musteri3.Soyadi = "doğan";
            musteri3.Id = "456789";
            musteri3.Cinsiyet = "erkek";
            musteri3.TcKimlik = "65748392019";

            Musteri[] MusteriListesi = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri item in MusteriListesi)
            {
                Console.WriteLine("===>"+item.Adi);
                Console.WriteLine("===>"+item.Soyadi);
                Console.WriteLine("===>"+item.Id);
                Console.WriteLine("===>"+item.TcKimlik);
                Console.WriteLine("===>"+item.Cinsiyet);

            }


            Console.WriteLine("----------------------");

            MüsteriManager musteriManager = new MüsteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("------------------");
            Console.WriteLine("MUSTERİ LİSTLENDİ.");
            musteriManager.MusteriListele(MusteriListesi);
            Console.WriteLine("--------------------");
            musteriManager.MusteriSil(musteri3);




            Console.ReadKey();
        }
    }
}
