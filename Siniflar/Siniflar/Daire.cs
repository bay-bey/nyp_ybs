using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Daire
    {
        public double yaricap;

        public Daire() { }//varsayılan kurucu metod


        public Daire(double yaricap)//kurucu(constructor) metod
        {
            this.yaricap = yaricap;
        }

        public double cevre()
        {
            return 2 * Math.PI * this.yaricap;
        }
        public double alan()
        {
            return Math.PI * this.yaricap * this.yaricap;
        }
        public void yazdir()
        {
            Console.WriteLine(
                "Dairenin yarıçapı:{0}, çevresi:{1}, alanı:{2}",
                this.yaricap, this.cevre(), this.alan() );
        }
    }
}
