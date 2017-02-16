using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen(2.5, 4);
            d1.yazdir();
            Dikdortgen d2 = new Dikdortgen(3.7, 4.1);
            d2.yazdir();
            Dikdortgen d3 = new Dikdortgen();
            d3.yazdir();
            Console.WriteLine("d3'ün alanı {0}", d3.alan());
        }
    }
}
