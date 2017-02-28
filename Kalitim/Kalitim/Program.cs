using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan("Kadir İnanır", "İstanbul", "Tiyatro");//insan oluştur(i1 nesnesi)
            i1.yazdir();//i1 nesnesinin yazdır metodunu çağır
            Hoca h1 = new Hoca();//hoca nesnesi oluştur(h1)
            h1.adi = "Şevket Çakır";//h1'in adını ata
            h1.bolum = "Bilgisayar Mühendisliği";//h1'in bölümünü ata
            h1.yazdir();//h1 hocasının yazdır metodunu çağır
            Hoca h2 = new Hoca("Abdülkadir Yaldır", "Denizli", "Yönetim Bilişim Sistemleri");//hoca nesnesi oluştur(h2)
            h2.yazdir();//h2'nin yazdır metodunu çağır
            h1.sinavYap();//h1 hocasının sinavYap metodunu çağır
            h2.sinavYap();//h2 hocasının sinavYap metodunu çağır

        }
    }
}
