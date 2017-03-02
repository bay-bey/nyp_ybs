using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulProjesiBO
{
    class Derslik
    {
        public List<Esya> esyalar = new List<Esya>();
        public string adi;
        public Derslik() { }
        public Derslik(string adi)
        {
            this.adi = adi;
        }

        public void esyaEkle(Esya esya)
        {
            esyalar.Add(esya);
        }
        public void esyaSil(Esya esya)
        {
            esyalar.Remove(esya);
        }
        public void yazdir()
        {
            Console.WriteLine("Derslik: {0}", adi);
            foreach (var e in esyalar)
            {
                e.yazdir();
            }
        }
        public double toplamEsyaFiyati()
        {
            double toplam = 0;
            foreach (var e in esyalar)
            {
                toplam += e.fiyati;
            }
            return toplam;
        }
        public double esyaFiyatOrtalamasi()
        {
            return toplamEsyaFiyati() / esyalar.Count;
        }

        public Esya enPahaliEsya()
        {
            if (esyalar.Count == 0)
                return null;
            Esya enpahali = esyalar[0];
            foreach (var e in esyalar)
            {
                if (e.fiyati > enpahali.fiyati)
                    enpahali = e;
            }
            return enpahali;
        }
    }
}
