using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciPaketleme
{
    class Ogrenci
    {
        public Ogrenci() {//kurucu metod
        }

        public string adi;
        public string soyadi;
        private int vize;
        private int final;

        /*
         * Ortalamayı hesaplayıp geri döndüren özellik(property)
         */ 
        public int Ortalama {
            get { return Convert.ToInt32(Math.Round(0.4 * vize + 0.6 * final)); }
        }
        /*
         * Parametre olarak gelen not değeri: 
         * 0'dan küçükse => 0
         * 100'den büyükse => 100
         * [0,100] aralığındaysa => kendi değeri
         */ 
        private int dogruDeger(int not)
        {
            if (not < 0)
                return 0;
            else if (not > 100)
                return 100;
            else
                return not;
        }
        /*
         * Vize özelliği. set için belirtilen aralıkta olup olmadığına bakar.
         */ 
        public int Vize {
            get { return vize; }
            set { vize = dogruDeger(value); }
        }
        /*
         * Final özelliği. set için belirtilen aralıkta olup olmadığına bakar.
         */
        public int Final
        {
            get { return final; }
            set { final = dogruDeger(value); }
        }

        public string HarfNotu {
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
