using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Otomasyonu_1575
{
    internal class Film
    {
        public int Id { get; set; }
        public string FilmAd { get; set; }
        public int Sure { get; set; }
        public string Tur { get; set; }
        public DateTime KayitTarih { get; set; }
        public bool Begenme { get; set; }

        public Film(int id, string filmAd, int sure, string tur, DateTime tarih, bool begenme)
        {
            Id = id;
            FilmAd = filmAd;
            Sure = sure;
            Tur = tur;
            KayitTarih = tarih;
            Begenme = begenme;
        }
    }
}
