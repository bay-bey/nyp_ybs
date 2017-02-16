using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi();
            //Console.Write("Adınızı Girin: ");
            //k1.ad = Console.ReadLine();
            k1.ad = "Şevket";
            k1.soyad = "Çakır";
            k1.gozRengi = "Ela";
            Kisi k2 = new Kisi();
            k2.ad = "Ertuğrul";
            k2.soyad = "Demircioğlu";
            k2.gozRengi = "Kahverengi";
            k2.dogumYili = 1996;
            Kisi k3 = new Kisi("Nurgül", "Çümen", 1996, "Ela");
            Kisi k4 = new Kisi("Kadir", "Çakır", 1951, "Kahverengi");
            k1.baba = k4;
            Kisi k5 = new Kisi("Ahmet", "Çakır", 1920, "Yeşil");
            k4.baba = k5;

            k1.yazdir();
            k2.yazdir();
            k3.yazdir();
        }
    }
}
