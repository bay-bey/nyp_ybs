using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    //İnsan sınıfı tanımlaması
    class Insan
    {
        public string adi;//ad özelliği
        protected string adresi;//adres özelliği
        public string bolum;//bölüm özelliği
        /*
         * varsayılan kurucu metod
         */
        public Insan()
        {
            adresi = "Antalya";
        }
        /*
         * parametre alan kurucu metodu
         */
        public Insan(string adi, string adresi, string bolum)
        {
            this.adi = adi;
            this.adresi = adresi;
            this.bolum = bolum;
        }
        /*
         * yazdir metodu: insanın bilgilerini yazdırır
         */ 
        public void yazdir()
        {
            Console.WriteLine("Insan sınıfının yazdir() metodu");
            Console.WriteLine("Adım:{0}",adi);
            Console.WriteLine("Adresim:{0}",adresi);
            Console.WriteLine("Bölümüm:{0}",bolum);
        }
    }
}
