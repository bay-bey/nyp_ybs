using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimBO
{
    class Kisi
    {
        public string adi;
        protected string adresi;
        public Kisi() {
            adresi = "Antalya";
        }
        public Kisi(string adi, string adresi)
        {
            this.adi = adi;
            this.adresi = adresi;
        }

        public void yazdir()
        {
            Console.WriteLine("Kisi sınıfının yazdir() metodu");
            Console.WriteLine("Adım: {0} Adresim: {1}", adi, adresi);
        }
    }
}
