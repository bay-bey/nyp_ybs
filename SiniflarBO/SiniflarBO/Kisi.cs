using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarBO
{
    class Kisi
    {
        public string ad;
        public string soyad;
        public int dogumYili;
        public string gozRengi;

        public Kisi()
        {
            dogumYili = 1990;
        }

        public Kisi(string ad, string soyad, int dogumYili, string gozRengi)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.dogumYili = dogumYili;
            this.gozRengi = gozRengi;
        }

        public void yazdir()
        {
            //Console.WriteLine("Kişi sınıfının yazdır metodu");
            Console.WriteLine("Adım: {0}", ad);
            Console.WriteLine("Soyadım: {0}", soyad);
            Console.WriteLine("Doğum yılım: {0}",dogumYili);
            Console.WriteLine("Göz rengim: {0}", gozRengi);
        }
    }
}
