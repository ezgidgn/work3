using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class MüsteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("müşteri eklendi.  müşteri adı soyadı:"+musteri.Adi+" "+musteri.Soyadi);
        }
        public void MusteriListele(Musteri[] MusteriListesi)
        {
            foreach (Musteri item in MusteriListesi)
            {
                

                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Soyadi);
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Cinsiyet);
                Console.WriteLine(item.TcKimlik);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müsteri silindi. Ad ve Soyad:"+musteri.Adi+" "+musteri.Soyadi);
        }

    }
}
