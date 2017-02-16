using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenBO
{
    class Dikdortgen
    {
        public double en;
        public double boy;
        public Dikdortgen()//Varsayılan kurucu metod
        {
            en = 10;
            boy = 15;
        }
        public Dikdortgen(double en, double boy)//Kurucu metod
        {
            this.en = en;
            this.boy = boy;
        }
        public double alan()
        {
            return en * boy;
        }
        public double cevre()
        {
            return 2 * (en + boy);
        }
        public void yazdir()
        {
            Console.WriteLine("En: {0} Boy: {1}", en, boy);
            Console.WriteLine("Alan: {0}", alan());
            Console.WriteLine("Çevre: {0}", cevre());
        }
    }
}
