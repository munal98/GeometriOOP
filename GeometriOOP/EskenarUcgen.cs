using System;

namespace GeometriDemo
{
    class EskenarUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        
        public double AlanHesapla()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(TabanKenar, 2);
        }

        public double CevreHesapla()
        {
            return 3 * TabanKenar;
        }
    }
}
