using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulProjesiBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Esya e1 = new Esya("Öğretmen Masası", 500);
            Esya e2 = new Esya("Öğretmen sandalyesi", 250);
            Esya e3 = new Esya("LG Televizyon", 2800);
            Derslik d1 = new Derslik("Lab. 1");
            d1.esyaEkle(e1);
            d1.esyaEkle(e2);
            d1.esyaEkle(e3);
            d1.esyaEkle(new Esya("Projeksiyon cihazı", 5000));
            //string ad;
            //double fiyat;
            //Console.Write("Eşya adı girin: ");
            //ad = Console.ReadLine();
            //Console.Write("Eşya fiyatı girin: ");
            //fiyat = double.Parse(Console.ReadLine());
            //d1.esyaEkle(new Esya(ad, fiyat));
            d1.yazdir();
            Console.WriteLine("Toplam eşya fiyatı: {0}", d1.toplamEsyaFiyati());
            Console.WriteLine("Eşya fiyat ortalaması: {0}", d1.esyaFiyatOrtalamasi());
            Console.Write("En pahalı eşya: ");
            Esya e = d1.enPahaliEsya();
            if (e != null)
                e.yazdir();
            
        }
    }
}
