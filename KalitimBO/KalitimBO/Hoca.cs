using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimBO
{
    class Hoca:Kisi
    {
        public string unvan;
        public Hoca() : base() { }

        public Hoca(string adi, string adresi, string unvani) : base(adi, adresi) { this.unvan = unvani; }

        public void adresSetle(string adres)
        {
            this.adresi = adres;
        }
    }
}
