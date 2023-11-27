using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta12_Destructor
{
    class Otomobil
    {
        string marka = "";
        string renk = "";
        public Otomobil()//Constuctor
        {
            marka = "TOGG";
            renk = "kırmızı";
            Console.WriteLine("Yapıcı metot çalıştı");
        }

        ~Otomobil() //Destructor
        {
            Console.WriteLine("Yıkıcı metot çalıştı");
        }

    }
}
