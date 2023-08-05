using System;

namespace GeometriDemo
{
    class Kare : IDortgen
    {
        public double UzunKenar { get; set; }

        public double AlanHesapla()
        {
            return Math.Pow(UzunKenar, 2);
        }

        public double CevreHesapla()
        {
            return (UzunKenar) * 4;
        }
    }
}
