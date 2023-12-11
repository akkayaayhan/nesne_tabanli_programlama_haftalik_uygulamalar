using System;

namespace Hafta12_Kalitim_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogr = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad = "Öz",
                brans="Mat"
            };

            OkulPersoneli per = ogr;
            Console.WriteLine(per.Ad);
        }
    }
}
