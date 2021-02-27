using System;
using System.Collections.Generic;
using System.Text;

namespace eBooks.Model
{
    public class Racuni
    {
        public int RacunId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int NarudzbaId { get; set; }

        public List<RacunStavke> RacunStavke { get; set; }
    }
}
