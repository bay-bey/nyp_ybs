using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatirlaticiBO
{
    class Zaman
    {
        private int saat;
        private int dakika;
        private int saniye;

        public int Saat
        {
            get { return saat; }
            set
            {
                saat = value % 24;
            }
        }

        public int Dakika
        {
            get { return dakika; }
            set
            {
                if (value >= 60)
                {
                    saat = value / 60;
                }
                dakika = value % 60;

            }
        }

        public int Saniye
        {
            get { return saniye; }
            set
            {
                if (value >= 60)
                {
                    dakika += value / 60;
                }
                saniye = value % 60;
            }
        }
        public Zaman(int saat, int dakika, int saniye)
        {
            this.Saniye = saniye;
            this.Dakika += dakika;
            this.Saat += saat;
        }

        public Zaman saniyeEkle(int saniye)
        {
            Zaman donecek = new Zaman(Saat, Dakika, Saniye);
            donecek.Saniye += saniye;
            return donecek;
        }
        public Zaman zamanEkle(Zaman z)
        {
            Zaman donecek = new Zaman(Saat, Dakika, Saniye);
            donecek.Saniye += z.Saniye;
            donecek.Dakika += z.Dakika;
            donecek.Saat += z.Saat;
            return donecek;
        }
    }
}
