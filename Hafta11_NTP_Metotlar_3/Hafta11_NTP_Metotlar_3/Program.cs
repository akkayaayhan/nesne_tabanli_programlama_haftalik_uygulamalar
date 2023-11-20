using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_NTP_Metotlar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometri dikdortgen = new Geometri();
            Console.WriteLine("Kısa kenarı gir");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarı gir");
            int k2 = Convert.ToInt32(Console.ReadLine());
            int alan=dikdortgen.alanHesapla(k1, k2);
            Console.WriteLine("Alan=" + alan);
            dikdortgen.cevreHesapla(k1, k2);
            Console.ReadKey();
        }
    }

    class Geometri
    {
        public String sekilAdi;
        public int kenarSayisi;

        public int alanHesapla(int kisaKenar,int uzunKenar)
        {

            return kisaKenar * uzunKenar;
        }

        public void cevreHesapla(int kisaKenar,int uzunKenar)
        {
            Console.WriteLine("Çevre=" + 2 * (kisaKenar + uzunKenar));
        }


    }
}
