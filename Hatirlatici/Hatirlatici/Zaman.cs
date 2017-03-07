using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatirlatici
{
    class Zaman
    {
        private int saat;
        private int dakika;
        private int saniye;

        public Zaman(int saat, int dakika, int saniye)
        {
            this.Saniye = saniye;
            this.Dakika += dakika;
            this.Saat += saat;
        }

        public int Saat
        {
            get { return saat; }
            set {
                saat = value % 24;
            }
        }

        public int Dakika
        {
            get { return dakika; }
            set {
                if (value >= 60)
                {
                    this.Saat += value / 60;
                }
                dakika = value % 60;
            }
        }

        public int Saniye
        {
            get { return saniye; }
            set {
                if (value >= 60)
                {
                    this.Dakika += value / 60;
                }
                saniye = value % 60;
            }
        }
        public Zaman saniyeEkle(int saniye)
        {
            Zaman z = new Zaman(Saat, Dakika, Saniye);
            z.Saniye += saniye;
            return z;
        }
        public Zaman zamanEkle(Zaman z)
        {
            Zaman z1 = new Zaman(Saat, Dakika, Saniye);
            z1.Saniye += z.Saniye;
            z1.Dakika += z.Dakika;
            z1.Saat += z.Saat;
            return z1;
        }
    }
}
