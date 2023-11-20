using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_NTP_Tekrar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--------Sporcu Bilgileri----------");
            Sporcu futbolcu = new Sporcu();
            futbolcu.sporcuDal = "Futbol";
            futbolcu.sporcuAdi = "Maouro Icardi";
            futbolcu.sporcuYas = 30;
            futbolcu.sporcuBoy = 1.85;
            futbolcu.sporcuKilo = 80;
            futbolcu.sporcuCinsiyet = 'E';
            futbolcu.bilgiler();
            Console.WriteLine("--------Antrenman Bilgileri----------");
            futbolcu.antrenman();
            Console.WriteLine("****************************");
            Sporcu voleybolcu = new Sporcu();
            Console.WriteLine("--------Sporcu Bilgileri----------");
            voleybolcu.sporcuDal = "Voleybol";
            voleybolcu.sporcuAdi = "Vargas";
            voleybolcu.sporcuYas = 20;
            voleybolcu.sporcuBoy = 1.95;
            voleybolcu.sporcuKilo = 50;
            voleybolcu.sporcuCinsiyet = 'K';
            voleybolcu.bilgiler();
            Console.WriteLine("--------Antrenman Bilgileri----------");
            voleybolcu.antrenman();
            Console.ReadKey();

        }
    }

    class Sporcu
    {
        public String sporcuDal;
        public String sporcuAdi;
        public int sporcuYas;
        public double sporcuBoy;
        public byte sporcuKilo;
        public char sporcuCinsiyet;

        public void antrenman()
        {
            Console.WriteLine("Günlük 5 km koşu");
            Console.WriteLine("Günlük 1 saat kardiyo");

            switch(sporcuDal)
            {
                case "Futbol":
                    Console.WriteLine("1 saat şut çalışması yap");
                    if (sporcuKilo >70)
                    {
                        Console.WriteLine("1 saat fazla koşu");
                    }
                    break;
                case "Voleybol":
                    Console.WriteLine("1 saat zıpla");
                    break;
                case "Halter":
                    Console.WriteLine("1 saat dumbell çalış");
                    break;
                default:
                    Console.WriteLine("İlgili ek çalışma bulunamadı");
                    break;

            }

        }

        public void bilgiler()
        {
            Console.WriteLine("Sporcunun Dalı :" + sporcuDal);
            Console.WriteLine("Sporcunun Adı :" + sporcuAdi);
            Console.WriteLine("Sporcunun Yaşı :" + sporcuYas);
            Console.WriteLine("Sporcunun Boyu :" + sporcuBoy);
            Console.WriteLine("Sporcunun Kilosu :" + sporcuKilo);
            if (sporcuCinsiyet == 'E')
            {
                Console.WriteLine("Sporcunun Cinsiyeti Erkek");

            }
            else
            {
                Console.WriteLine("Sporcunun Cinsiyeti Kadın");
            }
        }


    }
}


