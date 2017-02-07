using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP02022017_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, tahmin, deneme = 0;
            Random r = new Random();
            sayi = r.Next(0, 100);
            //Console.WriteLine(sayi);
            do
            {
                Console.Write("Tahmininizi girin: ");
                tahmin = int.Parse(Console.ReadLine());
                deneme++;
                if(sayi > tahmin)
                    Console.WriteLine("Belirlenen sayı daha büyük");
                else if(sayi < tahmin)
                    Console.WriteLine("Belirlenen sayı daha küçük");
                else
                    Console.WriteLine("Tebrikler. {0} denemede buldunuz", deneme);
            }
            while (tahmin != sayi);

        }
    }
}
