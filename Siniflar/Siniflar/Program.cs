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
            k1.adi = "Şevket";//k1 nesnesinin adi özelliğini belirle
            k1.soyadi = "Çakır";
            k1.gozRengi = "Ela";
            k2.adi = "Hüseyin";//k1 nesnesinin adi özelliğini belirle
            k2.soyadi = "Kızılkaya";
            k2.gozRengi = "Kahverengi";
            k2.dogumYili = 1994;
            Kisi k3 = new Kisi("Burak", "Atalay", "Kahverengi", 1994);//k3 nesnesinin özelliklerini kurucu metod yoluyla belirle
            Console.WriteLine("{0}'in yaşı {1}", k1.adi, k1.yas());
            Kisi k4 = new Kisi("Kadir", "Çakır", "Kahverengi", 1951);
            k1.baba = k4;
            Kisi k5 = new Kisi("Nazmiye", "Çakır", "Ela", 1953);
            k1.anne = k5;

            k1.yazdir();//k1 nesnesinin yazdır metodunu çağır
            k2.yazdir();//k2 nesnesinin yazdır metodunu çağır
            k3.yazdir();//k3 nesnesinin yazdır metodunu çağır

            Daire d1 = new Daire(10.0);
            Console.WriteLine("d1'in çevresi:{0} alanı:{1}", d1.cevre(), d1.alan());
            Daire d2 = new Daire();
            d2.yaricap = 20;
            d2.yazdir();

        }
    }
}
