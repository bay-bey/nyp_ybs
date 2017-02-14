using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Kisi//kişi sınıfı bildirimi
    {
        public string adi;//kişinin adını saklar
        public string soyadi;//soyadı özelliği
        public string gozRengi;//kişinin göz rengi
        public int dogumYili;//kişinin doğum yılı

        public Kisi()//Varsayılan kurucu metod
        {
            dogumYili = 1990;//kurucu metod parametresiz çalıştırıldığında doğum yılını 1990 olarak belirle
        }

        public Kisi(string adi, string soyadi, string gozRengi, int dogumYili)//parametre alan kurucu metod
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.gozRengi = gozRengi;
            this.dogumYili = dogumYili;
        }

        public void yazdir()//kişinin bilgilerini yazdıran metod
        {
            //Console.WriteLine("Ben bir kişi sınıfıyım");
            Console.WriteLine("Adım: {0}",adi);
            Console.WriteLine("Soyadım: {0}", soyadi);
            Console.WriteLine("Göz rengim: {0}", gozRengi);
            Console.WriteLine("Doğum yılım: {0}", dogumYili);
        }
    }
}
