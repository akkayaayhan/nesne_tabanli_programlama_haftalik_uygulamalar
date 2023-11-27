using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta12_Constructor_1
{
    class Kisi
    {
        int yas;
        string ad;

        public Kisi() //Constructor
        {
            yas = 19;
            ad = "Ahmet";
            Console.WriteLine("Yapıcı metot çalıştı");
        }

        public int Yas
        {
            get { return yas; }
        }

        public string Ad
        {
            get
            {
                return ad;
            }
        }


    }
}
