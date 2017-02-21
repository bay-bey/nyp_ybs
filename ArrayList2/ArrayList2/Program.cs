using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(2);
            a.Add(5);
            a.Add("Şevket");
            a.Add(3.141592);

            Kisi k1 = new Kisi();
            a.Add(k1);
            a.Add(14);
            yazdir(a);
            Console.WriteLine("Elemanların toplamı:{0}", tamsayilariTopla(a));
        }

        static void yazdir(ArrayList al)
        {
            foreach (var eleman in al)
            {
                Console.WriteLine(eleman);
            }
        }

        /*
         * ArrayList içindeki tamsayı değerlerini toplayıp geri döndürürü
         */
        static int tamsayilariTopla(ArrayList al)
        {
            int toplam = 0;
            foreach (var eleman in al)
            {
                //if(eleman.GetType() == typeof(int))
                if (eleman is int)//eleman tamsayı ise
                    toplam += (int)eleman;
            }
            return toplam;
        }
    }
}
