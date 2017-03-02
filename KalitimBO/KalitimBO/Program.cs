using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi("Emma Stone", "Arizona");
            k1.yazdir();
            Hoca h1 = new Hoca();
            h1.adi = "Şevket Çakır";
            h1.yazdir();
            Hoca h2 = new Hoca("Abdülkadir Yaldır", "Denizli", "Yrd.Doç.Dr.");
            h2.yazdir();
        }
    }
}
