using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListBO
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();//Arraylist oluştur
            a.Add(5);//Eleman ekleme
            a.Add(4);
            a.Add(7);
            a.Add(25);
            a.Add(42);
            yazdir(a);
            a.Add(7);
            yazdir(a);
            a.Remove(7);//Parametre olarak verilen elemanı silme
            yazdir(a);
            a.Insert(2, 55);//Araya eleman ekleme
            yazdir(a);
            a.RemoveAt(1);//Belirtilen indisteki elemanı silme
            yazdir(a);
            if(a.Contains(55))//Eleman ArrayList'te var mı?
                Console.WriteLine("55 değeri mevcut");
            Console.WriteLine("{0} eleman var",a.Count);//eleman sayısı
            a.Add(25);
            yazdir(a);
            Console.WriteLine("25 değeri {0} konumunda", a.IndexOf(25));//25'in konumunu verir, yoksa -1 döndürür
            a.Reverse();//ArrayList'i tersine çevir
            yazdir(a);
            a.Sort();//ArrayList'i küçükten büyüğe sırala
            yazdir(a);
            Console.WriteLine("2 konumundaki eleman:{0}", a[2]);//Köşeli parantezle(dizi gibi) erişme


        }

        static void yazdir(ArrayList al)
        {
            foreach (int eleman in al)
            {
                Console.Write("{0} ", eleman);
            }
            Console.WriteLine();
        }
    }
}
