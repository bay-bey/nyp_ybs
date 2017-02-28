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
        public double Ortalama {
            get { return 0.4 * vize + 0.6 * final; }
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
    }
}
