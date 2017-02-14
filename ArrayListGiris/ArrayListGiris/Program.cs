using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(2);
            a.Add(8);
            a.Add(7);
            a.Add(5);
            a.Add(15);
            a.Add(21);
            yazdir(a);
            a.Remove(15);
            a.Insert(2, 55);//Araya ekleme
            yazdir(a);
            a.Add(55);
            yazdir(a);
            a.Remove(55);//ilk 55'i sil
            yazdir(a);
            if(a.Contains(21))
                Console.WriteLine("21 değeri {0}. konumda", a.IndexOf(21));
            a.Add(44);
            a.Add(55);
            yazdir(a);
            Console.WriteLine("55'in konumu:{0}",a.LastIndexOf(55));
            Console.WriteLine(a[0]);//dizi gibi erişme
            a.RemoveAt(a.LastIndexOf(55));//son 55'i sil
            yazdir(a);
            Console.WriteLine("ArrayList içinde {0} eleman var.", a.Count);
            a.Reverse();//elemanların sırasını tersine çevir
            yazdir(a);
            a.Sort();//elemanları küçükten büyüğe sırala
            yazdir(a);



        }

        static void yazdir(ArrayList al)
        {
            foreach (int eleman in al)
            {
                Console.Write(eleman + ", ");
            }
            Console.WriteLine();
        }
    }
}
