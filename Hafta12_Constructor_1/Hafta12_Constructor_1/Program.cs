using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta12_Constructor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı");
            //Kisi k = new Kisi();//k nesnesi
            //Console.WriteLine("Adı: {0}, Yaşı: {1}", k.Ad, k.Yas);
            
            KisiParametreli kpInt = new KisiParametreli(25);
            KisiParametreli kpString = new KisiParametreli("ayhan");
            KisiParametreli kpIntString = new KisiParametreli(15, "efe");
            Console.WriteLine("Program bitti");
            Console.ReadKey();
        }
    }
}
