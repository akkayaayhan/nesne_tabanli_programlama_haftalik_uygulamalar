using System;

namespace Hafta14_SoyutSiniflar
{

    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int Modelyili { get; set; }

        public abstract void Calis();
        public abstract void Dur();
    }

    public class Otomobil : MotorluArac
    {
        public bool OtomatikVites { get; set; }
        public override void Calis()
        {
            Console.WriteLine("Otomobil Çalıştı");
        }

        public override void Dur()
        {
            Console.WriteLine("Otomobil durdu");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            // MotorluArac ma = new MotorluArac(); soyut sınıflardan nesne üretilemez.
            Otomobil oto = new Otomobil
            {
                Modelyili=2020,
                MotorHacmi=1600,
                OtomatikVites=true

            };
            oto.Calis();
            oto.Dur();
        }
    }
}
