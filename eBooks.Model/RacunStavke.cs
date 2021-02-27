using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class RacunStavke
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
