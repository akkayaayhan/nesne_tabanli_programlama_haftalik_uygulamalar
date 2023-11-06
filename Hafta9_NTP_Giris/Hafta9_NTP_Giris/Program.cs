using System;

namespace Hafta9_NTP_Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dikdörtgen Problemi");
            Dikdortgen d = new Dikdortgen(13,14);
            Console.WriteLine("Alan=" + d.alanHesapla());
            Console.WriteLine("Çevre=" + d.cevreHesapla());
            
        }
    }


    class Dikdortgen
    {
        public int a, b;
        public Dikdortgen(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public int alanHesapla()
        {
            return a * b;
        }

        public int cevreHesapla()
        {
            return 2 * (a + b);
        }

    }
}



