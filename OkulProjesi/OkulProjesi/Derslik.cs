using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulProjesi
{
    class Derslik
    {
        public string adi;
        List<Esya> esyalar=new List<Esya>();
        public Derslik() { }
        public Derslik(string adi)
        {
            this.adi = adi;
        }
        public void esyaEkle(Esya e)
        {
            esyalar.Add(e);
        }
        public void esyaSil(Esya e)
        {
            esyalar.Remove(e);
        }
        public void yazdir()
        {
            Console.WriteLine("Derslik Adı:{0}", adi);
            foreach (var esya in esyalar)
            {
                esya.yazdir();
            }
        }
        public double toplamEsyaFiyati()
        {
            double toplam = 0;
            foreach (var esya in esyalar)
            {
                toplam += esya.fiyati;
            }
            return toplam;
        }

        public double esyaFiyatOrtalamasi()
        {
            return toplamEsyaFiyati() / esyalar.Count;
        }
        
        public Esya enPahaliEsya()
        {
            Esya max = esyalar[0];//İlk elemanı en pahalı olarak belirle
            foreach (var esya in esyalar)//bütün esyalara bak
            {
                if (esya.fiyati > max.fiyati)//bakılan eşyanın fiyatı en pahlı eşyanın fiyatından büyükse
                    max = esya;//yeni en pahalı olarak bakılan eşyayı seç
            }
            return max;//en pahalı eşyayı döndür
        }
        

    }
}
