using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciPaketlemeBO
{
    class Ogrenci
    {
        public string adi;
        public string soyadi;
        private int vize;
        private int final;

        public int Final
        {
            get { return final; }
            set { final = araligaSinirla(value); }
        }

        public int Vize {
            get {
                return vize;
            }
            set {
                vize = araligaSinirla(value);
            }
        }

        public int araligaSinirla(int not)
        {
            if (not < 0)
                return 0;
            else if (not > 100)
                return 100;
            else
                return not;
        }

        public double Ortalama {
            get {
                return vize * 0.4 + final * 0.6;
            }
        }
    }
}
