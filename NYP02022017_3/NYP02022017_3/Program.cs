using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP02022017_3
{
    class Kisi
    {
        private string ad;
        private string soyad;
        private string eposta;
        public Kisi()
        { }
        public Kisi(string kisiAd, string kisiSoyad, string kisiEposta)
        {
            ad = kisiAd;
            soyad = kisiSoyad;
            eposta = kisiEposta;
        }
        public string getAd()
        { 
            return ad; 
        }
        public void setAd(string kisiAd)
        {
            ad = kisiAd;
        }
        public string getSoyad()
        {
            return soyad;
        }
        public void setSoyad(string kisiSoyad)
        {
            soyad = kisiSoyad;
        }
        public string getEposta()
        {
            return eposta;
        }
        public void setEposta(string kisiEposta)
        {
            eposta = kisiEposta;
        }

        public string getAdSoyad()
        {
            return ad + " " + soyad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            kisi1.setAd("Şevket Umut");
            Kisi kisi2 = new Kisi();
            kisi2.setAd("Ertuğrul");
            Console.WriteLine("1. kişinin adı: {0}", kisi1.getAd());
            Kisi kisi3 = new Kisi("Durukan", "Küpeli", "durukan@gmail.com");
            Console.WriteLine("3. kişinin adı soyadı: {0}", kisi3.getAdSoyad());
        }
    }
}
