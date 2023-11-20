using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta11_NTP_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Sayilar mat = new Sayilar();
            int cikarma=mat.temelMatematik(15, 6);
            Console.WriteLine("İşlem Sonucu: " + cikarma);
            int toplama = mat.temelMatematik(5, 6);
            Console.WriteLine("İşlem Sonucu: " + toplama);
            int carpma = mat.temelMatematik(5, 5);
            Console.WriteLine("İşlem Sonucu: " + carpma);

            Console.ReadKey();
        }

        
    }

    class Sayilar
    {
        public int temelMatematik(int x, int y)
        {
            if (x < y)
            {
                return x + y;
            }
            else if(x>y)
            {
                return x - y;
            }

            else
            {
                return x * y;
            }


        }
    }

    
}
