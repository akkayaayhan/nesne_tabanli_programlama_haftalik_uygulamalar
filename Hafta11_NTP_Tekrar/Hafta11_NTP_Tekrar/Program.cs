using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_NTP_Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Hafta11**************");
           
            Console.WriteLine("**************************");
            Dersler mat = new Dersler();
            mat.dersAdi = "Matematik";
            mat.dersSaati = 4;
            mat.dersKredi = 6;
            mat.dersNotu = 60;
            mat.islenenKonu = "Kümeler";
            mat.dersSecme();
            mat.dersGecme();
            Console.WriteLine("**************************");
            Dersler ntp = new Dersler();
            ntp.dersAdi = "Nesne Tabanlı Programlama";
            ntp.dersSaati = 10;
            ntp.dersKredi = 10;
            ntp.dersNotu = 40;
            ntp.islenenKonu = "Sınıflar";
            ntp.dersSecme();
            ntp.dersGecme();

            Console.ReadKey();
        }
    }
}

class Dersler
{
    //Derslere ait özellikler
    public String dersAdi;
    public byte dersSaati;
    public byte dersKredi;
    public String islenenKonu;
    public int dersNotu;

    public void dersSecme()
    {
        Console.WriteLine(dersAdi + " dersi seçildi");
        Console.WriteLine(dersAdi + " dersi Saati:"+dersSaati);
        Console.WriteLine(dersAdi + " dersi kredisi:"+dersKredi);  
    }

    public void dersGecme()
    {
        if (dersNotu >= 50)
        {
            Console.WriteLine(dersAdi + " dersinden geçtiniz");
            Console.WriteLine(dersAdi + " notunuz : " + dersNotu);
        }
        else
        {
            Console.WriteLine(dersAdi + " dersinden kaldınız");
            Console.WriteLine(dersAdi + "notunuz : " + dersNotu);
        }
    }


}

