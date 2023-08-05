using System;

namespace GeometriDemo
{
    class Daire
    {
        public double YariCap { get; set; }

        public double AlanHesapla()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }

        public double CevreHesapla()
        {
            return 2 * Math.PI * YariCap;
        }
    }
}
