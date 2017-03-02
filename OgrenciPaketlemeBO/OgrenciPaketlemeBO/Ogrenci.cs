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

        public int Ortalama {
            get {
                return Convert.ToInt32(Math.Round(vize * 0.4 + final * 0.6));
            }
        }
        /*
         * 90<=ortalama<=100 A1
         * 80<=ortalama<=89 A2
         * 75<=ortalama<=79 B1
         * 70<=ortalama<=74 B2
         * 65<=ortalama<=69 C1
         * 60<=ortalama<=64 C2
         * 55<=ortalama<=59 D1
         * 50<=ortalama<=54 D2
         * ortalama<=49 E
         */
        public string HafrNotu {
            get {
                if (Ortalama >= 90 && Ortalama <= 100)
                    return "A1";
                else if (Ortalama >= 80 && Ortalama < 90)
                    return "A2";
                else if (Ortalama >= 75 && Ortalama < 80)
                    return "B1";
                else if (Ortalama >= 70 && Ortalama < 75)
                    return "B2";
                else if (Ortalama >= 65 && Ortalama < 70)
                    return "C1";
                else if (Ortalama >= 60 && Ortalama < 65)
                    return "C2";
                else if (Ortalama >= 55 && Ortalama < 60)
                    return "D1";
                else if (Ortalama >= 50 && Ortalama < 55)
                    return "D2";
                else
                    return "E";
            }
        }
    }
}
