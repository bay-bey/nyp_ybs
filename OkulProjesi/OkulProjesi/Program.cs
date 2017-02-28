using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Esya e1 = new Esya("Masa", 150.0);
            Esya e2 = new Esya("Hoca Koltuğu", 200);
            Esya e3 = new Esya("Bilgisayar", 1500);

            Derslik d1 = new Derslik("Lab 1");
            d1.esyaEkle(e1);
            d1.esyaEkle(e2);
            d1.esyaEkle(e3);
            d1.esyaEkle(new Esya("LG Televizyon", 2800));
            d1.yazdir();
            Console.WriteLine("d1 toplam eşya fiyatı:{0}",d1.toplamEsyaFiyati());
            Console.WriteLine("d1 eşya fiyatı ortalaması:{0}",d1.esyaFiyatOrtalamasi());
            //Esya e = d1.enPahaliEsya();
            //e.yazdir();
            d1.enPahaliEsya().yazdir();//en pahalı eşyanın yazdır metodunu çağır
            //Derslik d2 = new Derslik();

        }
    }
}
