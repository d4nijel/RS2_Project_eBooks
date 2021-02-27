using System;
using System.Collections.Generic;

namespace eBooks.WebAPI.Database
{
    public partial class RacunStavke
    {
        public int RacunStavkeId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public int KnjigaId { get; set; }
        public int RacunId { get; set; }

        public Knjige Knjiga { get; set; }
        public Racuni Racun { get; set; }
    }
}
