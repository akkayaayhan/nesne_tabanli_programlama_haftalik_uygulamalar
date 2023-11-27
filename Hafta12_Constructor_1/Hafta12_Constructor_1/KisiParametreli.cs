using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta12_Constructor_1
{
    class KisiParametreli
    {
        int yas = 0;
        string ad = "";

        public KisiParametreli(int yas)
        {
            this.yas = yas;
            ad = "ahmet";
            Console.WriteLine("int parametreli constructor çalıştı");

        }

        public KisiParametreli(string ad)
        {
            yas = 19;
            this.ad = ad;
            Console.WriteLine("string parametreli constructor çalıştı");


        }

        public KisiParametreli(int yas,string ad)
        {
            this.yas = yas;
            this.ad = ad;
            Console.WriteLine("iki parametreli constructor çalıştı");

        }

    }
}
