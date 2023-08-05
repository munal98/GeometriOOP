using System;

namespace GeometriDemo
{
    class DikUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        public double Yukseklik { get; set; }
        public double Hipotenus
        {
            get
            {
                return Math.Sqrt(Math.Pow(TabanKenar, 2) + Math.Pow(Yukseklik, 2));
            }
        }

        public double AlanHesapla()
        {
            return (TabanKenar * Yukseklik) / 2;
        }

        public double CevreHesapla()
        {
            return Hipotenus + TabanKenar + Yukseklik;
        }
    }
}
