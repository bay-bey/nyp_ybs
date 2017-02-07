using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP020212017
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];//10 elemanlı tamsayı dizisi oluştur
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}. sayı girin: ",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int enkucuk = sayilar[0], enbuyuk = sayilar[0], toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < enkucuk)
                    enkucuk = sayilar[i];
                if (sayilar[i] > enbuyuk)
                    enbuyuk = sayilar[i];
                toplam += sayilar[i];
            }
            Console.WriteLine("En küçük sayı: {0}", enkucuk);
            Console.WriteLine("En büyük sayı: {0}", enbuyuk);
            Console.WriteLine("Ortalama: {0}", toplam / (double)sayilar.Length);
        }
    }
}
