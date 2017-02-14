using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Kisi
    {
        public string adi;//kişinin adını saklar
        public string soyadi;
        public string gozRengi;
        public int dogumYili;

        public Kisi()//Varsayılan kurucu metod
        {
            dogumYili = 1990;
        }

        public Kisi(string adi, string soyadi, string gozRengi, int dogumYili)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.gozRengi = gozRengi;
            this.dogumYili = dogumYili;
        }

        public void yazdir()
        {
            //Console.WriteLine("Ben bir kişi sınıfıyım");
            Console.WriteLine("Adım: {0}",adi);
            Console.WriteLine("Soyadım: {0}", soyadi);
            Console.WriteLine("Göz rengim: {0}", gozRengi);
            Console.WriteLine("Doğum yılım: {0}", dogumYili);
        }
    }
}
