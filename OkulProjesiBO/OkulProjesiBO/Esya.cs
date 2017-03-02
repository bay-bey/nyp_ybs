using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulProjesiBO
{
    class Esya
    {
        public string adi;
        public double fiyati;
        public Esya() { }
        public Esya(string adi, double fiyati)
        {
            this.adi = adi;
            this.fiyati = fiyati;
        }
        public void yazdir()
        {
            Console.WriteLine("Eşya adı:{0}, fiyatı:{1}", adi, fiyati);
        }
    }
}
