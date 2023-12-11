using System;

namespace Hafta14_SanalMetotlar
{
    public class Sekil
    {
        public const double pi = 3.14;
        protected double x, y;
        public Sekil()
        {
        }
        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double AlanHesapla()
        {
            return x * y;
        }
        public virtual void BilgiYazdir()
        {
            Console.WriteLine("x = " +x + " ve y = " +y);
        }
    }
    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0)
        {
        }
        public override double AlanHesapla()
        {
            return pi * x * x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sekil s = new Sekil(3, 4);
            s.BilgiYazdir();
            Console.WriteLine("Şekil alanı: " +s.AlanHesapla());
            Console.WriteLine("=======================");
            Daire d = new Daire(1.3);
            d.BilgiYazdir();
            Console.WriteLine("Daire alanı: { 0:N2}", d.AlanHesapla());
        }
    }

}
