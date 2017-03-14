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
        /*
         * Hatırlatıcı için kullanılan açıklama özelliği
         */ 
        private string aciklama;
        /*
         * ListView bileşeninde kullanmak için oluşturulan özellik(property)
         */ 
        public string Zaman1
        {
            get { return saat + ":" + dakika + ":" + saniye; }
        }
        /*
         * ListView bileşeninde gösterebilmek için oluşturulmuş özellik(property)
         */ 
        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }
        /*
         * Kurucu metod(constructor)
         */ 
        public Zaman(int saat, int dakika, int saniye)
        {
            this.Saniye = saniye;
            this.Dakika += dakika;
            this.Saat += saat;
        }
        /*
         * Saat özelliği. 24'e göre mod alıp fazlalığı atıyor
         */ 
        public int Saat
        {
            get { return saat; }
            set {
                saat = value % 24;
            }
        }
        /*
         * Dakika özelliği.60'dan büyük veya eşitse fazlalığı 
         * Saat değerine ekler
         */ 
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
        /*
         * Saniye özelliği. 60'dan büyük veya eşitse fazlalığı
         * Dakika değerine ekler.
         */ 
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

        /*
         * Mevcut zamanın üzerine belirtilen saniye kadar ekler
         * ve geriye yeni bir nesne döndürür. Çağrılan nesnenin
         * özellikleri değişmez.
         * Kullanımı:
         * Zaman z=new Zaman(12,12,12);
         * z.saniyeEkle(300);//12:17:12 döndürür
         */ 
        public Zaman saniyeEkle(int saniye)
        {
            Zaman z = new Zaman(Saat, Dakika, Saniye);
            z.Saniye += saniye;
            return z;
        }
        /*
         * Mevcut zamanın üzerine belirtilen zaman kadar ekler.
         * Kullanımı saniyeEkle metoduna benzer.
         */ 
        public Zaman zamanEkle(Zaman z)
        {
            Zaman z1 = new Zaman(Saat, Dakika, Saniye);
            z1.Saniye += z.Saniye;
            z1.Dakika += z.Dakika;
            z1.Saat += z.Saat;
            return z1;
        }
        /*
         * Tüm sınıflar object sınıfından türetilir ve object
         * sınıfının eşitliği kontrol eden Equals ve nesnenin
         * string olarak temsil edilmesini sağlayan ToString
         * gibi metodları bulunur. override kelimesi object
         * sınıfı içindeki ToString metodunu etkisiz kılıp kendi
         * ToString metodumuzu yazmak için kullanılır.
         * Tanımladığımız ToString metodu elimizdeki zaman 
         * nesnesini string olarak temsil etmemizi sağlar.
         * Örneğin ListBox bileşenine bir zaman nesnesi ekleyince
         * ListBox içinde aşağıdaki biçimde zamanın saati, 
         * dakikası ve saniyesi gözükür.
         */ 
        public override string ToString()
        {
            return Saat + ":" + Dakika + ":" + Saniye+" "+aciklama;
        }
        /*
         * Zaman sınıfından iki nesnenin birbirine eşit olup 
         * olmadığını bu metod sayesinde kontrol edebiliriz. Equals
         * metodu object sınıfından türetilen bir metoddur ve override
         * kelimesi bunun için gereklidir.
         */
        public override bool Equals(object obj)
        {
            Zaman z = (Zaman)obj;
            return Saat == z.Saat && Dakika == z.Dakika && Saniye == z.Saniye;
            //if (Saat == z.Saat && Dakika == z.Dakika && Saniye == z.Saniye)
            //    return true;
            //else
            //    return false;
        }
    }
}
