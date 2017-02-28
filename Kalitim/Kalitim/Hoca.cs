using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    /*
     * Hoca sınıfı Insan sınıfından türetilir.
     * Insan sınıfının tüm public elemanları Hoca sınıfında da devralınır ve hem sınıf 
     * metodlarında hem de sınıf dışında erişilebilir.
     * Insan sınıfının protected elemanları sadece türetilen sınıfın(Hoca) metodlarında 
     * kullanılabilir. 
     * Insan sınıfının private elemanları sadece Insan sınıfının metodlarında erişilebilir.
     */
    class Hoca:Insan
    {
        /*
         * Insan sınıfında olmayan, sadece Hoca sınıfına ait ünvan özelliği
         */ 
        public string unvan;
        /*
         * Hoca sınıfının varsayılan kurucu metodu Insan sınıfının varsayılan kurucu metodundan
         * türetilir. Dolayısıyla Insan sınıfının kurucu metodu da çağrılır.
         */ 
        public Hoca() : base() { }
        /*
         * Hoca sınıfının 3 parametre alan kurucu sınıfı Insan sınıfının 3 parametreli kurucu
         * sınıfından türetilir. Dolayısıyla Insan sınıfının 3 parametreli kurucu metodu da
         * çağrılır.
         */ 
        public Hoca(string adi, string adres, string bolum) : base(adi, adres, bolum) { }
        /*
         * Sadece hoca sınıfına ait adresSetle metodu. adres elemanı protected olduğu için
         * Hoca sınıfından erişilebilir.
         */ 
        public void adresSetle(string adres)
        {
            this.adresi = adres;
        }
        /*
         * Sadece Hoca sınıfına ait sinavYap metodu
         */ 
        public void sinavYap()
        {
            Console.WriteLine("{0} sınav yapıyor...", adi);
        }
    }
}
