using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciPaketleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            //Console.WriteLine(o1.Vize);
            Console.Write("Vize notunu girin: ");
            o1.Vize = int.Parse(Console.ReadLine());
            //Console.WriteLine(o1.Vize);
            Console.Write("Final notunu girin: ");
            o1.Final = int.Parse(Console.ReadLine());
            Console.WriteLine("Ortalama: {0}", o1.Ortalama );

        }
    }
}
