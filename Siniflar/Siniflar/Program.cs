using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi();//Kisi sınıfından k1 nesnesini oluştur
            Kisi k2 = new Kisi();//Kisi sınıfından k2 nesnesini oluştur
            k1.adi = "Şevket";
            k1.soyadi = "Çakır";
            k1.gozRengi = "Ela";
            k2.adi = "Hüseyin";
            k2.soyadi = "Kızılkaya";
            k2.gozRengi = "Kahverengi";
            k2.dogumYili = 1994;
            k1.yazdir();//k1 nesnesinin yazdır metodunu çağır
            k2.yazdir();//k2 nesnesinin yazdır metodunu çağır
            Kisi k3 = new Kisi("Burak", "Atalay", "Kahverengi", 1994);
            k3.yazdir();

        }
    }
}
