using System;

namespace Hafta9_NTP_Ogrenci
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ayhan = new Ogrenci(11111,"Ayhan Akkaya",125,60);
            Console.WriteLine("Öğrencinin TC :" + ayhan.tcNo);
            Console.WriteLine("Öğrencinin Adı Soyadı :" + ayhan.adSoyad);
            Console.WriteLine("Öğrencinin Okul No :" + ayhan.okulNo);
            Console.WriteLine("Öğrencinin Ders Notu :" + ayhan.dersNot);
            ayhan.devamDurumu(3);
            ayhan.disiplin("Telefon");

            Console.WriteLine("********************");
            Ogrenci ismail = new Ogrenci(22222, "İsmail Arpacık", 1528, 40);
            Console.WriteLine("Öğrencinin TC :" + ismail.tcNo);
            Console.WriteLine("Öğrencinin Adı Soyadı :" + ismail.adSoyad);
            Console.WriteLine("Öğrencinin Okul No :" + ismail.okulNo);
            Console.WriteLine("Öğrencinin Ders Notu :" + ismail.dersNot);
            ismail.devamDurumu(8);
            ismail.disiplin("Okuldan Kaçma");

            Console.WriteLine("********************");
            Ogrenci yasemin = new Ogrenci(3333, "Yasemin Matar", 1859, 80);
            Console.WriteLine("Öğrencinin TC :" + yasemin.tcNo);
            Console.WriteLine("Öğrencinin Adı Soyadı :" + yasemin.adSoyad);
            Console.WriteLine("Öğrencinin Okul No :" + yasemin.okulNo);
            Console.WriteLine("Öğrencinin Ders Notu :" + yasemin.dersNot);
            yasemin.devamDurumu(1);
            yasemin.disiplin("Yok");

        }
    }

    class Ogrenci
    {
        public double tcNo;
        public String adSoyad;
        public int okulNo;
        public byte dersNot;

        public Ogrenci(double tcNo,String adSoyad,int okulNo,byte dersNot)
        {
            this.tcNo = tcNo;
            this.adSoyad = adSoyad;
            this.okulNo = okulNo;
            this.dersNot = dersNot;

        }

        public void devamDurumu(int i)
        {
            Console.WriteLine("Öğreencinin Devamsızlık günü:" + i);
        }

        public void disiplin(String a)
        {
            Console.WriteLine("Öğrencinin Disiplin suçu:" + a);
        }
    }
}
