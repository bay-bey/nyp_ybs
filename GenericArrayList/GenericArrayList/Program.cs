using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();//Sadece tamsayıların eklenebileceği generic bir liste oluştur
            l.Add(5);
            l.Add(7);
            l.Add(26);
            if(l.Contains(7))
                Console.WriteLine("7 değeri mevcut");
            yazdir(l);
        }

        static void yazdir(List<int> l)
        {
            //int toplam = 0;
            foreach (var eleman in l)
            {
                //toplam += eleman;
                Console.WriteLine(eleman);
            }
        }
    }
}
